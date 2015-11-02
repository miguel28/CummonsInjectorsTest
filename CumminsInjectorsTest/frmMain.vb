Imports AutomationLib
Public Class frmMain
    Implements IStateMachineUpdatable

    Private sMachine As StateMachine

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sMachine = New StateMachine()
        sMachine.RegisterWindow(Me)
        sMachine.StartMachine()
    End Sub

    Public Sub UpdateMachineEvent() Implements IStateMachineUpdatable.UpdateMachineEvent

    End Sub

    Public Sub SetMessage(msg As String) Implements IStateMachineUpdatable.SetMessage
        lblMessage.Text = msg
    End Sub

    Public Sub AddValueCurrentGragph(value As Double) Implements IStateMachineUpdatable.AddValueCurrentGragph
        chartCurrent.AddValue(value)
    End Sub

    Public Sub AddValueDistanceGragph(value As Double) Implements IStateMachineUpdatable.AddValueDistanceGragph
        chartDistance.AddValue(value)
    End Sub

    Public Sub SetDistanceReference(value As Double) Implements IStateMachineUpdatable.SetDistanceReference
        chartDistance.ChartStyle.TargetValue = value
    End Sub
End Class
