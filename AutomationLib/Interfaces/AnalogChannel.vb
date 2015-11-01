Public Class AnalogChannel
    Public Bias As Double
    Public Scale As Double
    Public Value As Double

    Public Sub New()
        Bias = 0.0
        Scale = 0.0
        Value = 0.0
    End Sub

    Public Function GetChannel()
        GetChannel = (Value + Bias) * Scale
    End Function

End Class
