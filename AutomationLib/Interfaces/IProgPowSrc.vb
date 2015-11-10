Public Interface IProgPowSrc
    Sub SetOnline(online As Boolean)
    Sub SetVoltage(v As Double)
    Sub SetCurrent(a As Double)
    Sub SetCurrentLimit(a As Double)

    Function GetVoltage() As Double
    Function GetCurrent() As Double

    Sub SetValues(values() As CurrentProf)

End Interface
