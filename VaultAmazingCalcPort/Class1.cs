using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaultAmazingCalcPort;

namespace VaultAmazingCalcPortClass
{
    public class Class1
    {
        public static string Result = "0";

        public static long ResultParsed;
        public static long ResultNewParsed;
        public static long FinalResult;

        public static double ResultParsedD;
        public static double ResultNewParsedD;
        public static double FinalResultD;

        public static bool LastPlus;
        public static bool LastMinus;
        public static bool LastMult;
        public static bool LastDiv;

       











        public static void Reset()
        {
            Result = "0";
            ResultParsed = 0;
            ResultNewParsed = 0;

            ResultParsedD = 0;
            ResultNewParsedD = 0;
            FinalResultD = 0;

            BoolReset();
        }

        public static void BoolReset()
        {
            LastPlus = false;
            LastMinus = false;
            LastMult = false;
            LastDiv = false;
        }

    }
}
