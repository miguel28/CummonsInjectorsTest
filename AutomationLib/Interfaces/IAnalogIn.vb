Public Interface IAnalogIn
    Sub SetBias(channel As UShort, bias As Double)
    Sub SetScale(channel As UShort, scale As Double)
    Function GetAnalogIn(channel As UShort) As Double
End Interface
