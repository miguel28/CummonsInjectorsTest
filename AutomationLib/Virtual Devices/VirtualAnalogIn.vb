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

    Public Function GetAnalogInMultiple(channel As UShort) As Double() Implements IAnalogIn.GetAnalogInMultiple
        Dim data(0) As Double
        data(0) = 0.0

        GetAnalogInMultiple = data
        If channel >= maxChannels Then Exit Function
        data(0) = frmIOEmulator.GetInstance().AnalogChannels(channel).GetChannel()

        GetAnalogInMultiple = data
    End Function
End Class
