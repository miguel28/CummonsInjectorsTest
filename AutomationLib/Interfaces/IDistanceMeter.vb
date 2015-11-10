Public Interface IDistanceMeter
    Sub SendCommand(cmd As String)
    Sub ReceivedCommand(cmd As String)
    Sub Update(channel As Integer)
    Function ReadValue(channel As Integer) As Double
End Interface
