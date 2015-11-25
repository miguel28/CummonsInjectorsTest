using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace KeyenceWrapper
{
    public enum LKIF_FLOATRESULT
    {
        LKIF_FLOATRESULT_VALID,
        LKIF_FLOATRESULT_RANGEOVER_N,
        LKIF_FLOATRESULT_WAITING
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LKIF_FLOATVALUE
    {
        public LKIF_FLOATRESULT FloatResult;
        public float Value;
    }
    
    public static class Keyence
    {
        [DllImport("LkIF.dll")]
        public static extern bool LKIF_GetCalcData(out LKIF_FLOATVALUE CalcData1, out LKIF_FLOATVALUE CalcData2);
    }
}
