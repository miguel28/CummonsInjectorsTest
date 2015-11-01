Public Class VirtualAnalogIn
    Implements IAnalogIn
    Private maxChannels As Integer
    Public Sub New()
        maxChannels = 4
    End Sub
    Public Function GetAnalogIn(channel As UShort) As Double Implements IAnalogIn.GetAnalogIn
        GetAnalogIn = 0.0
        If channel >= maxChannels Then Exit Function
        GetAnalogIn = frmIOEmulator.GetInstance().AnalogChannels(channel).GetChannel()
    End Function

    Public Sub SetBias(channel As UShort, bias As Double) Implements IAnalogIn.SetBias
        If channel >= maxChannels Then Exit Sub
        frmIOEmulator.GetInstance().AnalogChannels(channel).Bias = bias
    End Sub

    Public Sub SetScale(channel As UShort, scale As Double) Implements IAnalogIn.SetScale
        If channel >= maxChannels Then Exit Sub
        frmIOEmulator.GetInstance().AnalogChannels(channel).Scale = scale
    End Sub
End Class
