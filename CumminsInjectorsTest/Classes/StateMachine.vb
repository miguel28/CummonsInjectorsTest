' State Machine 
'
'
'
Imports AutomationLib
Public Class StateMachine
    Public MStep As Integer
    Private timer As Timer
    Public config As ConfigReader
    Public window As IStateMachineUpdatable

    Public ioPort As IDiscretePort
    Public analogIn As IAnalogIn
    Public pwrSrc As IProgPowSrc

    Public ReferenceDistance As Double

    Private Shared instance As StateMachine
    Public Shared Function GetInstace() As StateMachine
        GetInstace = instance
    End Function

    Public Sub New()
        MStep = 0
        timer = New Timer()
        timer.Interval = 100
        AddHandler timer.Tick, AddressOf MachineUpdate

        config = ConfigReader.LoadConfg()
        config.SaveConfig()

        If config.UseEmulator = True Then
            Dim windowsEmu As frmIOEmulator
            windowsEmu = New frmIOEmulator()
            windowsEmu.Show()

            ioPort = New VirtualIO()
            analogIn = New VirtualAnalogIn()
            pwrSrc = New VirtualPowSrc()
        Else
            ioPort = New MCDaqUSB()
            analogIn = New NIAnalog6210()
            pwrSrc = New QuadTechPwSrc42000(config.PowerSourceComPortName, config.PowerSourceComPortBaud)
        End If

        analogIn.SetScale(config.CHNDistance, config.DistanceScale)

        instance = Me
    End Sub

    Public Sub RegisterWindow(win As IStateMachineUpdatable)
        window = win
    End Sub

    Public Sub StartMachine()
        timer.Start()
    End Sub

    Public Sub StopMachine()
        timer.Stop()
    End Sub

    Public Sub RestartMachine()
        MStep = 0
    End Sub

    Private Sub MachineUpdate()
        ioPort.Update()


        If ioPort.GetInput(config.INPeasureSwitch) = False Then
            MStep = 1
        End If


        Select Case MStep
            Case 0
                window.SetMessage("Inicializando Maquina")
                ioPort.Outputs = 0
                MStep = 1
            Case 1
                If ioPort.GetInput(config.INPeasureSwitch) = True Then
                    MStep = 2
                Else
                    window.SetMessage("Presion de Aire muy baja")
                    ioPort.Outputs = 0
                End If

            Case 2 ' Retract Piston
                ioPort.SetOutput(config.OUTRetractPiston, True)
                ioPort.SetOutput(config.OUTExtendPiston, False)

                If ioPort.GetInput(config.INPistonRetracted) = True Then
                    window.SetMessage("Maquina Lista")
                    MStep = 3
                Else
                    window.SetMessage("Retrayendo Piston")
                End If
                

            Case 3 ' When press antitie down then extend the piston
                If ioPort.GetInput(config.INAntiTieDown) = True Then
                    window.SetMessage("Bajando Piston")
                    MStep = 4
                End If

            Case 4
                ioPort.SetOutput(config.OUTRetractPiston, False)
                ioPort.SetOutput(config.OUTExtendPiston, True)

                ' When the piston is fully extended the goto step 5
                If ioPort.GetInput(config.INPistonExtended) = True Then
                    MStep = 5
                End If

                ' If is not fully extended then Retract Piston
                If ioPort.GetInput(config.INAntiTieDown) = False Then
                    MStep = 2
                End If

            Case 5 ' Measuring Reference Distance
                window.SetMessage("Tomando Medicion")
                Application.DoEvents()

                ' Sets up Power Source
                pwrSrc.SetOnline(True)
                pwrSrc.SetVoltage(24.0)
                pwrSrc.SetCurrent(50.0)
                pwrSrc.SetCurrentLimit(60.0)

                System.Threading.Thread.Sleep(1000) ' Wait 1 seccond to estabilish the sample
                ReferenceDistance = analogIn.GetAnalogIn(config.CHNDistance)
                window.SetDistanceReference(ReferenceDistance)
                window.SetMessage("Suelte Botones, para comenzar la medicion")
                MStep = 6

            Case 6 ' Begin Measure
                If ioPort.GetInput(config.INAntiTieDown) = False Then
                    MStep = 7
                End If

            Case 7 ' Measuring
                window.SetMessage("Midiendo, Para terminar la medicion vuelva a presionar los botones")
                window.AddValueDistanceGragph(analogIn.GetAnalogIn(config.CHNDistance))
                window.AddValueCurrentGragph(pwrSrc.GetCurrent())

                If ioPort.GetInput(config.INAntiTieDown) = True Then
                    ioPort.SetOutput(config.OUTRetractPiston, True)
                    ioPort.SetOutput(config.OUTExtendPiston, False)
                    MStep = 8
                End If

            Case 8
                window.SetMessage("Retrayendo Piston")
                If ioPort.GetInput(config.INPistonRetracted) = True Then
                    MStep = 9
                End If
            Case 9
                window.SetMessage("Suelte Botones")
                If ioPort.GetInput(config.INAntiTieDown) = False Then
                    MStep = 2
                End If

            Case Else
                MStep = 0
        End Select

        ioPort.Update()
        window.UpdateMachineEvent()
    End Sub

End Class
