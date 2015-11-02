Public Interface IStateMachineUpdatable
    Sub UpdateMachineEvent()
    Sub SetMessage(msg As String)
    Sub AddValueDistanceGragph(value As Double)
    Sub AddValueCurrentGragph(value As Double)
    Sub SetDistanceReference(value As Double)
End Interface
