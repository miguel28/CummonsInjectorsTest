Imports AutomationLib
Public Class frmMain
    Implements IStateMachineUpdatable


    Private sMachine As StateMachine

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sMachine = New StateMachine()
        sMachine.RegisterWindow(Me)

    End Sub

    Public Sub UpdateMachineEvent() Implements IStateMachineUpdatable.UpdateMachineEvent

    End Sub

    Public Sub SetMessage(msg As String) Implements IStateMachineUpdatable.SetMessage
        lblMessage.Text = msg
    End Sub
End Class
