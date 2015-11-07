Imports MccDaq
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

        InitializeDaq()
    End Sub

    Property Inputs As UInteger Implements IDiscretePort.Inputs
        Get
            Inputs = _inputs
        End Get
        Set(value As UInteger)
            _inputs = value
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
        val = 1 << input

        If value = True Then
            If GetInput(input) = False Then
                _inputs = _inputs + val
            End If
        Else
            If GetInput(input) = True Then
                _inputs = _inputs - val
            End If
        End If

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
        val = 1 << output

        If value = True Then
            If GetOutput(output) = False Then
                _outputs = _outputs + val
            End If

        Else
            If GetOutput(output) = True Then
                _outputs = _outputs - val
            End If
        End If
    End Sub
    Public Function GetOutput(output As UShort) As Boolean Implements IDiscretePort.GetOutput
        GetOutput = False
        If output >= maxInputs Then Exit Function

        Dim val As UInteger
        val = 1 << output

        If ((_outputs And val) >> output) = 1 Then GetOutput = True

    End Function
    Public Sub Update() Implements IDiscretePort.Update
        DaqUpdate()
    End Sub

    ' Daq Spesific Methods

    'Create a new MccBoard object for Board 0
    Private DaqBoard As MccDaq.MccBoard = New MccDaq.MccBoard(0)

    Private PortNumIn, PortNumOut As MccDaq.DigitalPortType
    Private NumPortsIn, NumBitsIn, FirstBitIn As Integer
    Private NumPortsOut, NumBitsOut, FirstBitOut As Integer
    Private ProgAbilityIn, ProgAbilityOut As Integer

    Private DirectionIn As MccDaq.DigitalPortDirection
    Private DirectionOut As MccDaq.DigitalPortDirection

    Private Sub InitializeDaq()
        InitUL()
        ConfigureInputs()
        ConfigureOutputs()
    End Sub
    Private Sub InitUL()

        Dim ULStat As MccDaq.ErrorInfo

        ' declare revision level of Universal Library

        ULStat = MccDaq.MccService.DeclareRevision(MccDaq.MccService.CurrentRevNum)

        ' Initiate error handling
        '  activating error handling will trap errors like
        '  bad channel numbers and non-configured conditions.
        '  Parameters:
        '    MccDaq.ErrorReporting.PrintAll :all warnings and errors encountered will be printed
        '    MccDaq.ErrorHandling.StopAll   :if any error is encountered, the program will stop

        Dim ReportError As MccDaq.ErrorReporting
        Dim HandleError As MccDaq.ErrorHandling

        ReportError = MccDaq.ErrorReporting.PrintAll
        HandleError = MccDaq.ErrorHandling.StopAll
        ULStat = MccDaq.MccService.ErrHandling(ReportError, HandleError)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then
            Stop
        End If
    End Sub

    Private Sub ConfigureInputs()
        Dim PortName As String
        Dim ULStat As MccDaq.ErrorInfo

        'determine if digital port exists, its capabilities, etc
        NumPortsIn = FindPortsOfType(DaqBoard, PORTIN, ProgAbilityIn, PortNumIn, NumBitsIn, FirstBitIn)
        If NumBitsIn > 8 Then NumBitsIn = 8

        If NumPortsIn < 1 Then
            'lblInstruct.Text = "There are no compatible digital ports on board " _
            '    & DaqBoard.BoardNum.ToString() & "."
        Else
            ' if programmable, set direction of port to input
            ' configure the first port for digital input
            '  Parameters:
            '    PortNum        :the input port
            '    Direction      :sets the port for input or output

            If ProgAbilityIn = DigitalIO.PROGPORT Then
                DirectionIn = MccDaq.DigitalPortDirection.DigitalIn
                ULStat = DaqBoard.DConfigPort(PortNumIn, DirectionIn)
                If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
            End If
            PortName = PortNumIn.ToString()
            'lblInstruct.Text = "You may change the value read by applying " & _
            '"a TTL high or TTL low to digital inputs on " & PortName & _
            '" on board " & DaqBoard.BoardNum.ToString() & "."
            'lblBitList.Text = "The first " & Format(NumBits, "0") & " bits are:"
        End If
    End Sub

    Private Sub ConfigureOutputs()
        Dim PortName As String
        Dim ULStat As MccDaq.ErrorInfo

        'determine if digital port exists, its capabilities, etc
        NumPortsOut = FindPortsOfType(DaqBoard, PORTOUT, ProgAbilityOut, PortNumOut, NumBitsOut, FirstBitOut)

        If NumPortsOut < 1 Then
            'lblInstruct.Text = "Board " & DaqBoard.BoardNum.ToString() & _
            '    " has no compatible digital ports."
            'hsbSetDOutVal.Enabled = False
            'txtValSet.Enabled = False
        Else
            ' if programmable, set direction of port to output
            ' configure the first port for digital output
            '  Parameters:
            '    PortNum        :the output port
            '    Direction      :sets the port for input or output

            If ProgAbilityOut = DigitalIO.PROGPORT Then
                DirectionOut = MccDaq.DigitalPortDirection.DigitalOut
                ULStat = DaqBoard.DConfigPort(PortNumOut, DirectionOut)
                If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
            End If
            PortName = PortNumOut.ToString()
            'lblInstruct.Text = "Set the output value of " & PortName & _
            '" on board " & DaqBoard.BoardNum.ToString() & _
            '" using the scroll bar or enter a value in the 'Value set' box."
            'lblValSet.Text = "Value set at " & PortName & ":"
            'lblDataValOut.Text = "Value written to " & PortName & ":"
        End If
    End Sub

    Private Sub DaqUpdate()
        Dim ULStat As MccDaq.ErrorInfo
        Dim DataValueIn As UInt16
        Dim DataValueOut As UInt16

        ' read digital input and display

        ' Parameters:
        '   PortNum    :the input port
        '   DataValue  :the value read from the port

        DataValueOut = _outputs

        ULStat = DaqBoard.DIn(PortNumIn, DataValueIn)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop

        ' write the value to the output port
        '  Parameters:
        '    PortNum    :the output port
        '    DataValue  :the value written to the port

        ULStat = DaqBoard.DOut(PortNumOut, DataValueOut)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop

        _inputs = DataValueIn
    End Sub

End Class
