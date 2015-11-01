Public Class MCDaqUSB
    Implements IDiscretePort
    Private _inputs As UInteger
    Private _outputs As UInteger
    Private maxInputs As Integer
    Private maxOutputs As Integer

    Public Sub New()
        _inputs = 0
        _outputs = 0
        maxInputs = 8
        maxOutputs = 8
    End Sub

    Property Inputs As UInteger Implements IDiscretePort.Inputs
        Get
            Inputs = _inputs
        End Get
        Set(value As UInteger)

        End Set
    End Property

    Property Outputs As UInteger Implements IDiscretePort.Outputs
        Get
            Outputs = _outputs
        End Get
        Set(value As UInteger)
            _outputs = value
        End Set
    End Property
    Public Sub SetInput(input As UShort, value As Boolean) Implements IDiscretePort.SetInput
        If input >= maxInputs Then Exit Sub

        Dim val As UInteger
        val = value << input
        _inputs = _inputs Or val
    End Sub
    Public Function GetInput(input As UShort) As Boolean Implements IDiscretePort.GetInput
        GetInput = False
        If input >= maxInputs Then Exit Function

        Dim val As UInteger
        val = 1 << input

        If ((_inputs And val) >> input) = 1 Then GetInput = True
    End Function
    Public Sub SetOutput(output As UShort, value As Boolean) Implements IDiscretePort.SetOutput
        If output >= maxOutputs Then Exit Sub

        Dim val As UInteger
        val = value << output
        _outputs = _outputs Or val

    End Sub
    Public Function GetOutput(output As UShort) As Boolean Implements IDiscretePort.GetOutput
        GetOutput = False
        If output >= maxInputs Then Exit Function

        Dim val As UInteger
        val = 1 << output

        If ((_outputs And val) >> output) = 1 Then GetOutput = True

    End Function
    Public Sub Update() Implements IDiscretePort.Update

    End Sub
End Class
