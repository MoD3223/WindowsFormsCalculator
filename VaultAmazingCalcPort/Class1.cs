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

        //Result > Parsed > New Parsed > Final > Parsed....

        public static double ResultParsedD;
        public static double ResultNewParsedD;
        public static double FinalResultD;

        //LastX = Last pressed from bools below
        public static bool LastPlus;
        public static bool LastMinus;
        public static bool LastMult;
        public static bool LastDiv;
        public static bool LastZero;
        //Multi = multiplying by itself
        public static bool LastMulti;

        //LastInputX = Last pressed button, used to prevent spam
        public static bool LastInputPlus;
        public static bool LastInputMinus;
        public static bool LastInputMult;
        public static bool LastInputDiv;

        

        public static string ToInt = "Error! Number too high.";
        public static string ToDouble = "Error! Can't parse the number.";

        public static double ResultParsedToD;
        public static double ResultNewParsedToD;
        public static double FinalResultToD;

        // public static int x;
        //x shows how many times we multipy by itself
        //public static double y = 0;
         //For divide
        public static string FinalDivString;


        public static void Reset()
        {
            Result = "0";
            ResultParsed = 0;
            ResultNewParsed = 0;
            FinalResult = 0;

            ResultParsedD = 0;
            ResultNewParsedD = 0;
            FinalResultD = 0;

            LastBoolReset();
            LastInputBoolReset();
        }

        public static void LastBoolReset()
        {
            LastPlus = false;
            LastMinus = false;
            LastMult = false;
            LastDiv = false;
            LastMulti = false;
        }

        public static void LastInputBoolReset()
        {
            LastInputPlus = false;
            LastInputMinus = false;
            LastInputMult = false;
            LastInputDiv = false;
        }



    }
}
