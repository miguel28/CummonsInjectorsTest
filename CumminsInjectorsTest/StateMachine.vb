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

    Private Shared instance As StateMachine
    Public Shared Function GetInstace() As StateMachine
        GetInstace = instance
    End Function

    Public Sub New()
        MStep = 0
        timer = New Timer
        timer.Interval = 100
        AddHandler timer.Tick, AddressOf MachineUpdate

        config = New ConfigReader()
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

        Select Case MStep
            Case 0

            Case Else
                MStep = 0
        End Select

        window.UpdateMachineEvent()
    End Sub

End Class
