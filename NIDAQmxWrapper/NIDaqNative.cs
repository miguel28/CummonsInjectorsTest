using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using TaskHandle = System.UInt32;

namespace NIDAQmxWrapper
{
    public static class NIDaqNative
    {
        public readonly static int DAQmx_Val_Cfg_Default = -1;

        //*** Values for DAQmx_Scale_PreScaledUnits ***
        //*** Value set UnitsPreScaled ***
        public readonly static int DAQmx_Val_Volts   = 10348; // Volts
        public readonly static int DAQmx_Val_Amps    = 10342; // Amps
        public readonly static int DAQmx_Val_DegF    = 10144; // Deg F
        public readonly static int DAQmx_Val_DegC    = 10143; // Deg C
        public readonly static int DAQmx_Val_DegR    = 10145; // Deg R
        public readonly static int DAQmx_Val_Kelvins = 10325; // Kelvins
        public readonly static int DAQmx_Val_Strain  = 10299; // Strain
        public readonly static int DAQmx_Val_Ohms    = 10384; // Ohms
        public readonly static int DAQmx_Val_Hz      = 10373; // Hz
        public readonly static int DAQmx_Val_Seconds = 10364; // Seconds
        public readonly static int DAQmx_Val_Meters  = 10219; // Meters
        public readonly static int DAQmx_Val_Inches  = 10379; // Inches
        public readonly static int DAQmx_Val_Degrees = 10146; // Degrees
        public readonly static int DAQmx_Val_Radians = 10273; // Radians
        public readonly static int DAQmx_Val_g       = 10186; // g
        
        //*** Values for the Fill Mode parameter of DAQmxReadAnalogF64, DAQmxReadBinaryI16, DAQmxReadBinaryU16, DAQmxReadDigitalU8, DAQmxReadDigitalU32, DAQmxReadDigitalLines ***
        //*** Values for the Data Layout parameter of DAQmxWriteAnalogF64, DAQmxWriteBinaryI16, DAQmxWriteDigitalU8, DAQmxWriteDigitalU32, DAQmxWriteDigitalLines ***
        public readonly static uint DAQmx_Val_GroupByChannel    = 0; // Group by Channel
        public readonly static uint DAQmx_Val_GroupByScanNumber = 1; // Group by Scan Number

        //*** Value set for the ActiveEdge parameter of DAQmxCfgSampClkTiming ***
        public readonly static uint DAQmx_Val_Rising  = 10280; // Rising
        public readonly static uint DAQmx_Val_Falling = 10171; // Falling

        //*** Values for DAQmx_SampQuant_SampMode ***
        //*** Value set AcquisitionType ***
        public readonly static uint DAQmx_Val_FiniteSamps = 10178; // Finite Samples
        public readonly static uint DAQmx_Val_ContSamps   = 10123; // Continuous Samples

        private const string DLL_NAME = "nidaqmxbase.dll";
        // C# doesn't support varargs so all arguments must be explicitly defined.
        // CallingConvention.Cdecl must be used since the stack is
        // cleaned up by the caller.
        [DllImport(DLL_NAME, CharSet = CharSet.Ansi,
                    CallingConvention = CallingConvention.Cdecl)]
        public static extern int DAQmxBaseCreateTask(
                    string taskName, out TaskHandle taskHandle);

        [DllImport(DLL_NAME, CharSet = CharSet.Ansi,
                    CallingConvention = CallingConvention.Cdecl)]
        public static extern int DAQmxBaseCreateAIVoltageChan(
                    TaskHandle taskHandle, string physicalChannel,
                    string nameToAssignToChannel, int config, double minVal, double maxVal,
                    int units, string custonScaleName);

        [DllImport(DLL_NAME, CharSet = CharSet.Ansi,
                    CallingConvention = CallingConvention.Cdecl)]
        public static extern int DAQmxBaseCfgSampClkTiming(
                    TaskHandle taskHandle, string source, double rate, int activeEdge,
                    int sampleMode, UInt64 sampsPerChan);

        [DllImport(DLL_NAME, CharSet = CharSet.Ansi,
                    CallingConvention = CallingConvention.Cdecl)]
        public static extern int DAQmxBaseCfgDigEdgeStartTrig(
                    TaskHandle taskHandle, string triggerSource, int triggerEdge);

        [DllImport(DLL_NAME, CharSet = CharSet.Ansi,
                    CallingConvention = CallingConvention.Cdecl)]
        public static extern int DAQmxBaseReadAnalogF64(
                    TaskHandle taskHandle, int numSampsPerChan, double timeout, 
                    UInt32 fillMode, out double[] readArray, System.UInt32 arraySizeInSamps, 
                    out int sampsPerChanRead, out System.UInt32 reserved);

        // float64 readArray[], uInt32 arraySizeInSamps, int32 *sampsPerChanRead, bool32 *reserved);
        /*
          [DllImport(DLL_NAME, CharSet = CharSet.Ansi,
                    CallingConvention = CallingConvention.Cdecl)]
        public static extern int DAQmxBaseReadAnalogF64(
                    TaskHandle taskHandle, int numSampsPerChan, double timeout,
                    UInt32 fillMode, ref double[] readArray, UInt32 arraySizeInSamps,
                    out int sampsPerChanRead, UInt32 reserved);
         */

        [DllImport(DLL_NAME, CharSet = CharSet.Ansi,
                    CallingConvention = CallingConvention.Cdecl)]
        public static extern int DAQmxBaseStartTask(TaskHandle taskHandle);

        [DllImport(DLL_NAME, CharSet = CharSet.Ansi,
                    CallingConvention = CallingConvention.Cdecl)]
        public static extern int DAQmxBaseStopTask(TaskHandle taskHandle);

        [DllImport(DLL_NAME, CharSet = CharSet.Ansi,
                    CallingConvention = CallingConvention.Cdecl)]
        public static extern int DAQmxBaseClearTask(TaskHandle taskHandle);
    }


}
