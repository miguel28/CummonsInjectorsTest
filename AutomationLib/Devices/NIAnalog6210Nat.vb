Imports NIDAQmxWrapper

Public Class NIAnalog6210Nat
    Implements IAnalogIn

    Public Sub New()
        Initialize()
    End Sub

    Public Function GetAnalogIn(channel As UShort) As Double Implements IAnalogIn.GetAnalogIn
        GetAnalogIn = analogInTask.ReadSingleSample()
    End Function

    Public Function GetAnalogInMultiple(channel As UShort) As Double() Implements IAnalogIn.GetAnalogInMultiple
        Dim data(0) As Double
        data(0) = analogInTask.ReadSingleSample()
        GetAnalogInMultiple = data
    End Function

    Public Sub SetBias(channel As UShort, bias As Double) Implements IAnalogIn.SetBias

    End Sub

    Public Sub SetScale(channel As UShort, scale As Double) Implements IAnalogIn.SetScale

    End Sub

    Private analogInTask As NIDaqTask  'A new Task is created when the Start Button is clicked

    Private Sub Initialize()
        Dim localDev As String
        Dim rangeMin, rangeMax As Double

        rangeMin = 0
        rangeMax = 5

        localDev = "Dev1/ai0"
        '"dev1/ai0", //The physical name of the channel
        analogInTask = New NIDaqTask("aiTask")
        analogInTask.CreateVoltageChannel(localDev, _
                                          "", _
                                         NIDaqNative.DAQmx_Val_Cfg_Default, _
                                         rangeMin, _
                                         rangeMax, _
                                         NIDaqNative.DAQmx_Val_Volts)
        '"/Dev1/PFI0"
        analogInTask.ConfigureSampleClock("", _
                                            10000, _
                                            NIDaqNative.DAQmx_Val_Rising, _
                                            NIDaqNative.DAQmx_Val_ContSamps, _
                                            1000)

        'analogInTask.ConfigureDigitalEdgeTrigger("PFI0", NIDaqNative.DAQmx_Val_Rising)

        'Verify the Task
        'analogInTask.Control(TaskAction.Verify)

        'Create the reader object
        'reader = New AnalogMultiChannelReader(analogInTask.Stream)
        'reader.SynchronizingObject = Me

        'Start the Task and set the read position
        analogInTask.Start()
        'analogInTask.Stream.ReadRelativeTo = ReadRelativeTo.CurrentReadPosition

        'analogInTask.Stop()
        'analogInTask.Dispose()


    End Sub

End Class
