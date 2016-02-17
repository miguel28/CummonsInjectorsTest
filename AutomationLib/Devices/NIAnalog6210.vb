Imports NationalInstruments.DAQmx

Public Class NIAnalog6210
    Implements IAnalogIn
    Private sscale As Double
    Public Sub New()
        Initialize()
    End Sub

    Public Function GetAnalogIn(channel As UShort) As Double Implements IAnalogIn.GetAnalogIn

        Dim data() As Double
        data = reader.ReadSingleSample()
        GetAnalogIn = data(0) * sscale
        'Dim data(,) As Double
        'data = reader.ReadMultiSample(1000)
        'GetAnalogIn = data(0, 0) * sscale
    End Function

    Public Function GetAnalogInMultiple(channel As UShort) As Double() Implements IAnalogIn.GetAnalogInMultiple
        Dim data(,) As Double
        Dim ret(0) As Double
        data = reader.ReadMultiSample(1000)
        ret(0) = data(0, 0)
        GetAnalogInMultiple = ret
    End Function

    Public Sub SetBias(channel As UShort, bias As Double) Implements IAnalogIn.SetBias

    End Sub

    Public Sub SetScale(channel As UShort, scale As Double) Implements IAnalogIn.SetScale
        sscale = scale
    End Sub

    Private analogInTask As Task  'A new Task is created when the Start Button is clicked
    Private reader As AnalogMultiChannelReader

    Private Sub Initialize()
        Dim localDevs() As String
        Dim localDev As String

        Dim rangeMin, rangeMax As Double

        rangeMin = 0
        rangeMax = 5

        localDevs = DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AI, PhysicalChannelAccess.External)
        If localDevs.Length = 0 Then
            Throw New Exception("No se ha encontrado DAQ de National Instruments")
        End If

        localDev = localDevs(1)
        '"dev1/ai0", //The physical name of the channel

        analogInTask = New Task("aiTask")
        analogInTask.AIChannels.CreateVoltageChannel(localDev, _
                                                     "", _
                                                     AITerminalConfiguration.Rse, _
                                                     rangeMin, _
                                                     rangeMax, _
                                                     AIVoltageUnits.Volts)

        'analogInTask.Timing.ConfigureSampleClock("", _
        '                                        1000, _
        '                                        SampleClockActiveEdge.Rising, _
        '                                        SampleQuantityMode.ContinuousSamples, _
        '                                        100)

        'Dim triggerEdge As DigitalEdgeStartTriggerEdge
        'triggerEdge = DigitalEdgeStartTriggerEdge.Rising
        'analogInTask.Triggers.StartTrigger.ConfigureDigitalEdgeTrigger("", triggerEdge)

        'Verify the Task
        analogInTask.Control(TaskAction.Verify)

        'Create the reader object
        reader = New AnalogMultiChannelReader(analogInTask.Stream)
        'reader.SynchronizingObject = Me

        'Start the Task and set the read position
        analogInTask.Start()
        analogInTask.Stream.ReadRelativeTo = ReadRelativeTo.CurrentReadPosition

        'analogInTask.Stop()
        'analogInTask.Dispose()
    End Sub
End Class
