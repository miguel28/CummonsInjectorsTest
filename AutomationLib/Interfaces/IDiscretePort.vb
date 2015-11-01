Public Interface IDiscretePort
    Property Inputs As UInteger
    Property Outputs As UInteger
    Sub SetInput(input As UShort, value As Boolean)
    Function GetInput(input As UShort) As Boolean
    Sub SetOutput(output As UShort, value As Boolean)
    Function GetOutput(output As UShort) As Boolean
    Sub Update()
End Interface
