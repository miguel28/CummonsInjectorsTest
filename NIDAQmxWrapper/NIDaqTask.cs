using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskHandle = System.UInt32;

namespace NIDAQmxWrapper
{
    public class NIDaqTask : IDisposable
    {
        private TaskHandle taskHandle;

        public NIDaqTask()
        {
            int a = NIDaqNative.DAQmxBaseCreateTask("", out taskHandle);
        }
        public NIDaqTask(string taskName)
        {
            int a = NIDaqNative.DAQmxBaseCreateTask(taskName, out taskHandle);
        }

        public void Start()
        {
            NIDaqNative.DAQmxBaseStartTask(taskHandle);
        }

        public void Stop()
        {
            NIDaqNative.DAQmxBaseStopTask(taskHandle);
        }

        public void Dispose()
        {
            NIDaqNative.DAQmxBaseClearTask(taskHandle);
        }

        public void CreateVoltageChannel(string devName, string referenceName, int config, double min, double max, int units)
        {
            int a = NIDaqNative.DAQmxBaseCreateAIVoltageChan(taskHandle, devName, referenceName, config, min, max, units, null);
        }

        public void ConfigureSampleClock(string source, double rate, int activeEdge, int sampleMode, UInt64 sampsPerChan)
        {
            int a = NIDaqNative.DAQmxBaseCfgSampClkTiming(taskHandle, source, rate, activeEdge, sampleMode, sampsPerChan);
        }

        public void ConfigureDigitalEdgeTrigger(string triggerSource, int triggerEdge)
        {
            NIDaqNative.DAQmxBaseCfgDigEdgeStartTrig(taskHandle, triggerSource, triggerEdge);
        }

        public double ReadSingleSample()
        {
            double[] values = new double[8000];
            int values_total = 0;
            uint einternal = 0;
            int a = NIDaqNative.DAQmxBaseReadAnalogF64(taskHandle, 10, 0.10, NIDaqNative.DAQmx_Val_GroupByChannel,
                    out values, 1000, out values_total, out einternal);

            if (values_total > 0)
                return values[0];
            else
                return 0.0;
        }
    }
}
