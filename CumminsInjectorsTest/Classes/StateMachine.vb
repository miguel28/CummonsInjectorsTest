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
    Public distanceMeter As IDistanceMeter

    Public ReferenceDistance As Double
    Private measure As Boolean



    Private Shared instance As StateMachine
    Public Shared Function GetInstace() As StateMachine
        GetInstace = instance
    End Function

    Public Sub New()
        MStep = 0
        timer = New Timer()
        timer.Interval = 100
        AddHandler timer.Tick, AddressOf MachineUpdate

        config = New ConfigReader()
        'config = ConfigReader.LoadConfg()
        config.SaveConfig()

        If config.UseEmulator = True Then
            Dim windowsEmu As frmIOEmulator
            windowsEmu = New frmIOEmulator()
            windowsEmu.Show()

            ioPort = New VirtualIO()
            analogIn = New VirtualAnalogIn()
            pwrSrc = New VirtualPowSrc()
            distanceMeter = New VirtualDistanceMeter()
        Else
            ioPort = New MCDaqUSB()
            analogIn = New NIAnalog6210()
            pwrSrc = New QuadTechPwSrc42000(config.PowerSourceComPortName, config.PowerSourceComPortBaud)
            distanceMeter = New LK_G_Distance(config.DistanceMeterComPortName, config.DistanceMeterComPortBaud)
        End If

        analogIn.SetScale(config.CHNCurrent, config.CHNCurrentScale)

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

    Public Sub BeginMeasure(val As Boolean)
        measure = val
    End Sub

    Private Sub MachineUpdate()
        ioPort.Update()

        If ioPort.GetInput(config.INPeasureSwitch) = False Then
            MStep = 1
        End If

        ' Enable button if the machine is ready to measure
        If MStep = 6 Or MStep = 7 Then
            If measure = True Then
                window.SetMeasureButtonEnable(measure, True, "Detener Medicion")
            Else
                window.SetMeasureButtonEnable(measure, True, "Empezar Medir")
            End If
        Else
            window.SetMeasureButtonEnable(measure, False, "Medir")
        End If


        ' State Machine Logic
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
                measure = False
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

            Case 5
                window.SetMessage("Suelte Botones, para comenzar la medicion")
                If ioPort.GetInput(config.INAntiTieDown) = False Then
                    window.SetMessage("Listo para medicion")
                    MStep = 6
                End If

            Case 6 ' Begin Measure
                If measure = True Then
                    window.SetMessage("Tomando Medicion de referencia")
                    Application.DoEvents()

                    System.Threading.Thread.Sleep(500) ' Wait 1/2 seccond to estabilish the sample
                    ReferenceDistance = distanceMeter.ReadValue(config.DISTChannel)
                    window.SetDistanceReference(ReferenceDistance)

                    ' Sets up Power Source
                    pwrSrc.SetOnline(True)

                    MStep = 7
                End If

            Case 7 ' Measuring
                distanceMeter.Update(config.DISTChannel)

                If measure = True Then
                    window.SetMessage("Midiendo, Para terminar la medicion vuelva a presionar el boton")
                    window.AddValueDistanceGragph(distanceMeter.ReadValue(config.DISTChannel))
                    window.AddValueCurrentGragph(analogIn.GetAnalogIn(config.CHNCurrent))
                End If

                If ioPort.GetInput(config.INAntiTieDown) = True And measure = False Then
                    ioPort.SetOutput(config.OUTRetractPiston, True)
                    ioPort.SetOutput(config.OUTExtendPiston, False)

                    pwrSrc.SetOnline(False)

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
