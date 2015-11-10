Public Class VirtualDistanceMeter
    Implements IDistanceMeter

    Public Function ReadValue(channel As Integer) As Double Implements IDistanceMeter.ReadValue
        ReadValue = frmIOEmulator.GetInstance().Distance
    End Function

    Public Sub ReceivedCommand(cmd As String) Implements IDistanceMeter.ReceivedCommand

    End Sub

    Public Sub SendCommand(cmd As String) Implements IDistanceMeter.SendCommand

    End Sub

    Public Sub Update(channel As Integer) Implements IDistanceMeter.Update

    End Sub
End Class
