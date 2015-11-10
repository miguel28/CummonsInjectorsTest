Public Interface IStateMachineUpdatable
    Sub UpdateMachineEvent()
    Sub SetMessage(msg As String)
    Sub AddValueDistanceGragph(value As Double)
    Sub AddValueCurrentGragph(value As Double)
    Sub SetDistanceReference(value As Double)
    Sub SetMeasureButtonEnable(value As Boolean, en As Boolean, text As String)
End Interface
