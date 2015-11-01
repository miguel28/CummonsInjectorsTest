Public Class NIAnalog6210
    Implements IAnalogIn

    Public Function GetAnalogIn(channel As UShort) As Double Implements IAnalogIn.GetAnalogIn
        GetAnalogIn = 0.0
    End Function

    Public Sub SetBias(channel As UShort, bias As Double) Implements IAnalogIn.SetBias

    End Sub

    Public Sub SetScale(channel As UShort, scale As Double) Implements IAnalogIn.SetScale

    End Sub
End Class
