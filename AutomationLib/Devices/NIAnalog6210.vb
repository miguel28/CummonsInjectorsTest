Imports NationalInstruments.DAQmx

Public Class NIAnalog6210
    Implements IAnalogIn

    Public Sub New()
        Initialize()
    End Sub

    Public Function GetAnalogIn(channel As UShort) As Double Implements IAnalogIn.GetAnalogIn
        'double[] data = reader.ReadMultiSample(100);
        Dim data() As Double
        data = reader.ReadSingleSample()
        GetAnalogIn = data(0)

    End Function

    Public Sub SetBias(channel As UShort, bias As Double) Implements IAnalogIn.SetBias

    End Sub

    Public Sub SetScale(channel As UShort, scale As Double) Implements IAnalogIn.SetScale
        
    End Sub

    Private analogInTask As Task  'A new Task is created when the Start Button is clicked
    Private reader As AnalogMultiChannelReader

    Private Sub Initialize()
        Dim localDevs() As String
        Dim localDev As String

        Dim rangeMin, rangeMax As Double

        rangeMin = 0
        rangeMax = 20

        localDevs = DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AI, PhysicalChannelAccess.External)
        localDev = localDevs(0)
        '"dev1/ai0", //The physical name of the channel

        analogInTask = New Task("aiTask")
        analogInTask.AIChannels.CreateVoltageChannel(localDev, _
                                                     "", _
                                                     CType(-1, AITerminalConfiguration), _
                                                     rangeMin, _
                                                     rangeMax, _
                                                     AIVoltageUnits.Volts)

        analogInTask.Timing.ConfigureSampleClock("/Dev1/PFI0", _
                                                 10000, _
                                                 SampleClockActiveEdge.Rising, _
                                                 SampleQuantityMode.ContinuousSamples, _
                                                 1000)

        Dim triggerEdge As DigitalEdgeStartTriggerEdge
        triggerEdge = DigitalEdgeStartTriggerEdge.Rising
        analogInTask.Triggers.StartTrigger.ConfigureDigitalEdgeTrigger("PFI0", triggerEdge)

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
