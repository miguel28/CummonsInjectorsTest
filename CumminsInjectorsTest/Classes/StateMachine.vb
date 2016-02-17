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
    Public PartNumer As String
    Private measure As Boolean

    Private distanceStack As ValuesStack
    Private currentStack As ValuesStack

    Public MaintenanceMode As Boolean

    Private Shared instance As StateMachine
    Public Shared Function GetInstace() As StateMachine
        GetInstace = instance
    End Function

    Public Sub New()
        MStep = 0
        timer = New Timer()
        timer.Interval = 10
        AddHandler timer.Tick, AddressOf MachineUpdate

        instance = Me

        'config = New ConfigReader()
        config = ConfigReader.LoadConfg()
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
            Try
                ioPort = New MCDaqUSB()
                pwrSrc = New QuadTechPwSrc42000(config.PowerSourceComPortName, config.PowerSourceComPortBaud)
                pwrSrc.SetValues(config.CurrentProfiles)
                distanceMeter = New LKGKeyenceUSB()
                analogIn = New NIAnalog6210()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error al inicializar dispositivos de la maquina", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            
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

    Public Sub EnterMaintenanceMode(val As Boolean)
        MaintenanceMode = val
        If val = True Then
            MStep = 50
        Else
            MStep = 0
        End If
    End Sub

    Private Sub TakeDistanceReference()
        Application.DoEvents()
        System.Threading.Thread.Sleep(500) ' Wait 1/2 seccond to estabilish the sample
        Dim distance As Double = distanceMeter.ReadValue(config.DISTChannel)
        If distance > 10000 Then distance = 10000

        ReferenceDistance = distance
        window.SetDistanceReference(ReferenceDistance)
        distanceStack.SetReference(ReferenceDistance)
    End Sub

    Private Sub StartMeasure()
        ' Sets up Power Source
        Try
            pwrSrc.SetOnline(True)
        Catch ex As Exception
            timer.Stop()
            MessageBox.Show(ex.ToString(), "Error al inizializar la funte de poder", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Environment.Exit(1)
        End Try

    End Sub

    Private Sub Measuring()
        Try
            distanceMeter.Update(config.DISTChannel)

            Dim dis As Double = distanceMeter.ReadValue(config.DISTChannel)
            window.AddValueDistanceGragph(dis)
            distanceStack.Push(dis)
        Catch ex As Exception

        End Try

        Try
            Dim cur As Double = analogIn.GetAnalogIn(config.CHNCurrent)
            window.AddValueCurrentGragph(cur)
            currentStack.Push(cur)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub StopMeasure()
        ' Sets up Power Source
        pwrSrc.SetOnline(False)
    End Sub

    Private Sub MachineUpdate()
        ioPort.Update()

        ' if the machine is not in maintenance mode
        If MaintenanceMode = True Then
            MStep = 50
            Exit Sub
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

        If MStep = 6 Or MStep = 7 Then
            If ioPort.GetInput(config.INPeasureSwitch) = False Then
                pwrSrc.SetOnline(False)
                distanceStack.Save("Piece_" + PartNumer + "_Distance.csv")
                currentStack.Save("Piece_" + PartNumer + "_Current.csv")
            End If
        End If

        If ioPort.GetInput(config.INPeasureSwitch) = False Then
            MStep = 1
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

            Case 2 ' Check if the piston is up
                measure = False
                window.SetMessage("Presione los botones para enviar la maquina a su posicion inicial")

                If ioPort.GetInput(config.INAntiTieDown) = True Then
                    ioPort.SetOutput(config.OUTRetractPiston, True)
                    ioPort.SetOutput(config.OUTExtendPiston, False)
                    window.SetMessage("Subiendo Piston")
                Else
                    ioPort.SetOutput(config.OUTRetractPiston, False)
                    ioPort.SetOutput(config.OUTExtendPiston, False)
                End If

                If ioPort.GetInput(config.INPistonRetracted) = True Then
                    window.SetMessage("Maquina Lista, suelte los botones")
                    If ioPort.GetInput(config.INAntiTieDown) = False Then
                        MStep = 3
                    End If
                End If

            Case 3 ' When press antitie down then extend the piston
                window.SetMessage("Maquina Lista, Presione los botones para iniciar la secuencia")
                If ioPort.GetInput(config.INAntiTieDown) = True Then
                    window.SetMessage("Bajando Piston")
                    MStep = 4
                End If

            Case 4
                ' When the piston is fully extended the goto step 5
                If ioPort.GetInput(config.INPistonExtended) = True Then
                    MStep = 5
                End If

                ' If is not fully extended then stop Piston
                If ioPort.GetInput(config.INAntiTieDown) = True Then
                    ioPort.SetOutput(config.OUTRetractPiston, False)
                    ioPort.SetOutput(config.OUTExtendPiston, True)
                Else
                    ioPort.SetOutput(config.OUTRetractPiston, False)
                    ioPort.SetOutput(config.OUTExtendPiston, False)
                End If

            Case 5
                window.SetMessage("Suelte Botones, para comenzar la medicion")
                If ioPort.GetInput(config.INAntiTieDown) = False Then
                    window.SetMessage("Listo para medicion")

                    'configure charts
                    analogIn.SetScale(config.CHNCurrent, config.CHNCurrentScale)
                    configDisGraph(frmMain.GetInstance().chartDistance, config.DistanceViewMin, config.DistanceViewmax)
                    configCurGraph(frmMain.GetInstance().chartCurrent, config.CurrentMin, config.CurrentMax)

                    MStep = 6
                End If

            Case 6 ' Begin Measure
                If measure = True Then
                    window.SetMessage("Tomando Medicion de referencia")

                    distanceStack = New ValuesStack(config.NumberSamples)
                    currentStack = New ValuesStack(config.NumberSamples)

                    TakeDistanceReference()
                    StartMeasure()
                    window.SetMessage("Midiendo, Para terminar la medicion vuelva a presionar el boton")
                    MStep = 7
                End If

            Case 7 ' Measuring
                If measure = True Then Measuring()
                ioPort.SetOutput(4, measure) ' Prende Aire para bajar embolo

                If ioPort.GetInput(config.INAntiTieDown) = True And measure = False Then
                    ioPort.SetOutput(config.OUTRetractPiston, True)
                    ioPort.SetOutput(config.OUTExtendPiston, False)

                    StopMeasure()
                    distanceStack.Save("Piece_" + PartNumer + "_Distance.csv")
                    currentStack.Save("Piece_" + PartNumer + "_Current.csv")

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
