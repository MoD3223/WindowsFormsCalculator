using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaultAmazingCalcPortClass;

namespace VaultAmazingCalcPort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Class1.Result = "0";
        }
        /*
        TODO:
        -Fix dividing when result is a float and not long //Make it always parse to double and if it contains .0 parse to int64 //Fixed? Trying to parse just the output leaving normal numbers alone
        -Fix converting to Double when it isn't first number containing "," //Fixed?
        -Check if Diving by 0 doesn't crash the app
        
            -Use LastZero bool //Done
            -add multiplying by itself as a for loop // Can't do x*x=x in for loop
        */
        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (Class1.Result == "0")
            {
                Class1.Result = "1";
            }
            else
            {
                Class1.Result += "1";
            }
            lblResult.Text = Class1.Result;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (Class1.Result == "0")
            {
                Class1.Result = "2";
            }
            else
            {
                Class1.Result += "2";
            }
            lblResult.Text = Class1.Result;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (Class1.Result == "0")
            {
                Class1.Result = "3";
            }
            else
            {
                Class1.Result += "3";
            }
            lblResult.Text = Class1.Result;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (Class1.Result == "0")
            {
                Class1.Result = "4";
            }
            else
            {
                Class1.Result += "4";
            }
            lblResult.Text = Class1.Result;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (Class1.Result == "0")
            {
                Class1.Result = "5";
            }
            else
            {
                Class1.Result += "5";
            }
            lblResult.Text = Class1.Result;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (Class1.Result == "0")
            {
                Class1.Result = "6";
            }
            else
            {
                Class1.Result += "6";
            }
            lblResult.Text = Class1.Result;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (Class1.Result == "0")
            {
                Class1.Result = "7";
            }
            else
            {
                Class1.Result += "7";
            }
            lblResult.Text = Class1.Result;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (Class1.Result == "0")
            {
                Class1.Result = "8";
            }
            else
            {
                Class1.Result += "8";
            }
            lblResult.Text = Class1.Result;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (Class1.Result == "0")
            {
                Class1.Result = "9";
            }
            else
            {
                Class1.Result += "9";
            }
            lblResult.Text = Class1.Result;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (Class1.LastZero)
            {
                
                Class1.Result += "0";
                lblResult.Text = Class1.Result;
            }
            else
            {
                Class1.LastZero = true;
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            Class1.Result += ",";
            lblResult.Text = Class1.Result;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (Class1.LastPlus == true)
            {
                Add();
                Class1.BoolReset();
            }
            else if (Class1.LastMinus == true)
            {
                Substract();
                Class1.BoolReset();
            }
            else if (Class1.LastMult == true)
            {
                Multiply();
                Class1.BoolReset();
            }
            else if (Class1.LastDiv == true)
            {
                Divide();
                Class1.BoolReset();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Add();
            Class1.LastPlus = true;
            Class1.LastMinus = false;
            Class1.LastMult = false;
            Class1.LastDiv = false;

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Substract();
            Class1.LastPlus = false;
            Class1.LastMinus = true;
            Class1.LastMult = false;
            Class1.LastDiv = false;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Multiply();
            Class1.LastPlus = false;
            Class1.LastMinus = false;
            Class1.LastMult = true;
            Class1.LastDiv = false;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Divide();
            Class1.LastPlus = false;
            Class1.LastMinus = false;
            Class1.LastMult = false;
            Class1.LastDiv = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Class1.Reset();
            lblResult.Text = Class1.Result;
        }

        private void btnBckSpace_Click(object sender, EventArgs e)
        {
            Class1.Result = Class1.Result.Substring(0, Class1.Result.Length -1);
            if (Class1.Result.Length == 0)
            {
                Class1.Result += "0";
            }
            lblResult.Text = Class1.Result;
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            if (Class1.Result.Contains("-"))
            {
                Class1.Result = Class1.Result.Remove(0, 1);
            }
            else
            {
                Class1.Result = Class1.Result.Insert(0, "-");
            }

            lblResult.Text = Class1.Result;
        }

        private void Add()
        {
            
            //Doubles below
             if (Class1.FinalResultD != 0)
            {
                if (Double.TryParse(Class1.Result, out Class1.ResultParsedD))
                {
                    Class1.FinalResultD = Class1.FinalResultD + Class1.ResultParsedD;

                    lblResult.Text = Class1.FinalResultD.ToString();
                    Class1.Result = "0";
                }
                else
                {
                    lblResult.Text = Class1.ToInt;
                }
            }
            else if (Class1.ResultParsedD != 0)
            {
                if (Double.TryParse(Class1.Result, out Class1.ResultNewParsedD))
                {
                    Class1.FinalResultD = Class1.ResultParsedD + Class1.ResultNewParsedD;

                    //Class1.ResultParsedD is Double
                    //Class1.ResultNewParsedD is Double
                    //Class1.FinalResultD is Double

                    lblResult.Text = Class1.FinalResultD.ToString();
                    //One time change to string, no need to convert to double again, it does it automatically
                    Class1.Result = "0";
                }
                else
                {
                    lblResult.Text = Class1.ToDouble;
                }
            }
            else if (Class1.Result.Contains(","))
            {
                if (Class1.FinalResult != 0)
                {
                   Class1.FinalResultToD = Convert.ToDouble(Class1.FinalResult);
                    if (Double.TryParse(Class1.Result,out Class1.ResultParsedD))
                    {
                        Class1.FinalResultD = Class1.FinalResultToD + Class1.ResultParsedD;
                        lblResult.Text = Class1.FinalResultD.ToString();
                        Class1.Result = "0";
                    }
                    else
                    {
                        lblResult.Text = Class1.ToDouble;
                    }
                    
                }
                else if (Class1.ResultParsed != 0)
                {
                    Class1.ResultParsedToD = Convert.ToDouble(Class1.ResultParsed);
                    if (Double.TryParse(Class1.Result, out Class1.ResultNewParsedD))
                    {
                        Class1.FinalResultD = Class1.ResultParsedToD + Class1.ResultNewParsedD;
                        lblResult.Text = Class1.FinalResultD.ToString();
                        
                        Class1.Result = "0";

                    }
                    else
                    {
                        lblResult.Text = Class1.ToDouble;
                    }
                }
                else if (Double.TryParse(Class1.Result, out Class1.ResultParsedD))
                {
                    Class1.Result = "0";
                    lblResult.Text = Class1.Result;
                    //Class1.ResultParsedD is Double
                    //Class1.Result is String
                }
                else
                {
                    lblResult.Text = Class1.ToDouble;
                }
            }

            //long because int is not enough
            else if (Class1.FinalResult != 0)
             {
                 if (Int64.TryParse(Class1.Result, out Class1.ResultParsed))
                 {Class1.FinalResult = Class1.FinalResult + Class1.ResultParsed;
                     lblResult.Text = Convert.ToString(Class1.FinalResult);
                     Class1.Result = "0";
                 }
                 else
                 {
                     lblResult.Text = Class1.ToInt;
                 }
             }   
            else if (Class1.ResultParsed != 0)
            {
                if (Int64.TryParse(Class1.Result, out Class1.ResultNewParsed))
                {
                    Class1.FinalResult = Class1.ResultParsed + Class1.ResultNewParsed;
                    lblResult.Text = Convert.ToString(Class1.FinalResult);
                    Class1.Result = "0";
                }
                else
                {
                    lblResult.Text = Class1.ToInt;
                }

            }
            else
            {
                
                if (Int64.TryParse(Class1.Result, out Class1.ResultParsed))
                {
                    // Parse successful. value can be any int64
                    Class1.Result = "0";
                    lblResult.Text = Class1.Result;
                }
                else
                {
                    // Parse failed. value will be 0.
                    lblResult.Text = Class1.ToInt;
                }
            }
        }
        private void Substract()
        {

            if (Class1.FinalResultD != 0)
            {
                if (Double.TryParse(Class1.Result, out Class1.ResultParsedD))
                {
                    Class1.FinalResultD = Class1.FinalResultD - Class1.ResultParsedD;
                    lblResult.Text = Class1.FinalResultD.ToString();
                    Class1.Result = "0";
                }
                else
                {
                    lblResult.Text = Class1.ToDouble;
                }
            }
            else if (Class1.ResultParsedD != 0)
            {
                if (Double.TryParse(Class1.Result, out Class1.ResultNewParsedD))
                {
                    Class1.FinalResultD = Class1.ResultParsedD - Class1.ResultNewParsedD;
                    lblResult.Text = Class1.FinalResultD.ToString();
                    Class1.Result = "0";
                }
                else
                {
                    lblResult.Text = Class1.ToDouble;
                }
            }
            else if (Class1.Result.Contains(","))
            {
                if (Class1.FinalResult != 0)
                {
                    Class1.FinalResultToD = Convert.ToDouble(Class1.FinalResult);
                    if (Double.TryParse(Class1.Result,out Class1.ResultParsedD))
                    {
                        Class1.FinalResultD = Class1.FinalResultToD - Class1.ResultParsedD;
                        lblResult.Text = Class1.FinalResultD.ToString();
                        Class1.Result = "0";
                    }
                    else
                    {
                        lblResult.Text = Class1.ToDouble;
                    }
                    
                }
                else if (Class1.ResultParsed != 0)
                {
                    Class1.ResultParsedToD = Convert.ToDouble(Class1.ResultParsed);
                    if (Double.TryParse(Class1.Result, out Class1.ResultNewParsedD))
                    {
                        Class1.FinalResultD = Class1.ResultParsedToD - Class1.ResultNewParsedD;
                        lblResult.Text = Class1.FinalResultD.ToString();
                        
                        Class1.Result = "0";

                    }
                    else
                    {
                        lblResult.Text = Class1.ToDouble;
                    }
                }
                else if (Double.TryParse(Class1.Result, out Class1.ResultParsedD))
                {
                    Class1.Result = "0";
                    lblResult.Text = Class1.Result;
                }
                else
                {
                    lblResult.Text = Class1.ToDouble;
                }
            }
            else if (Class1.FinalResult != 0)
            {
                if (Int64.TryParse(Class1.Result, out Class1.ResultParsed))
                {
                    Class1.FinalResult = Class1.FinalResult - Class1.ResultParsed;
                    lblResult.Text = Convert.ToString(Class1.FinalResult);
                    Class1.Result = "0";
                }
                else
                {
                    lblResult.Text = Class1.ToInt;
                }
            }
            else if (Class1.ResultParsed != 0)
            {
                if (Int64.TryParse(Class1.Result, out Class1.ResultNewParsed))
                {
                    Class1.FinalResult = Class1.ResultParsed - Class1.ResultNewParsed;
                    lblResult.Text = Convert.ToString(Class1.FinalResult);
                    Class1.Result = "0";
                }
                else
                {
                    lblResult.Text = Class1.ToInt;
                }
            }
            else
            {
                if (Int64.TryParse(Class1.Result, out Class1.ResultParsed))
                {
                    Class1.Result = "0";
                    lblResult.Text = Class1.Result;
                }
                else
                {
                    lblResult.Text = Class1.ToInt;
                }
            }
        }
        private void Multiply()
        {
            if (Class1.FinalResultD != 0)
            {
                if (Double.TryParse(Class1.Result, out Class1.ResultParsedD))
                {
                    Class1.FinalResultD = Class1.FinalResultD * Class1.ResultParsedD;
                    lblResult.Text = Class1.FinalResultD.ToString();
                    Class1.Result = "0";
                }
                else
                {
                    lblResult.Text = Class1.ToDouble;
                }
            }
            else if (Class1.ResultParsedD != 0)
            {
                if (Double.TryParse(Class1.Result, out Class1.ResultNewParsedD))
                {
                    Class1.FinalResultD = Class1.ResultParsedD * Class1.ResultNewParsedD;
                    lblResult.Text = Class1.FinalResultD.ToString();
                    Class1.Result = "0";
                }
                else
                {
                    lblResult.Text = Class1.ToDouble;
                }
            }
            else if (Class1.Result.Contains(","))
            {
                if (Class1.FinalResult != 0)
                {
                    Class1.FinalResultToD = Convert.ToDouble(Class1.FinalResult);
                    if (Double.TryParse(Class1.Result,out Class1.ResultParsedD))
                    {
                        Class1.FinalResultD = Class1.FinalResultToD * Class1.ResultParsedD;
                        lblResult.Text = Class1.FinalResultD.ToString();
                        Class1.Result = "0";
                    }
                    else
                    {
                        lblResult.Text = Class1.ToDouble;
                    }
                    
                }
                else if (Class1.ResultParsed != 0)
                {
                    Class1.ResultParsedToD = Convert.ToDouble(Class1.ResultParsed);
                    if (Double.TryParse(Class1.Result, out Class1.ResultNewParsedD))
                    {
                        Class1.FinalResultD = Class1.ResultParsedToD * Class1.ResultNewParsedD;
                        lblResult.Text = Class1.FinalResultD.ToString();
                        
                        Class1.Result = "0";

                    }
                    else
                    {
                        lblResult.Text = Class1.ToDouble;
                    }
                }
                else if (Double.TryParse(Class1.Result, out Class1.ResultParsedD))
                {
                    Class1.Result = "0";
                    lblResult.Text = Class1.Result;
                }
                else
                {
                    lblResult.Text = Class1.ToDouble;
                }
            }
            else if (Class1.FinalResult != 0)
            {
                if (Int64.TryParse(Class1.Result, out Class1.ResultParsed))
                {
                    Class1.FinalResult = Class1.FinalResult * Class1.ResultParsed;
                    lblResult.Text = Convert.ToString(Class1.FinalResult);
                    Class1.Result = "0";
                }
                else
                {
                    lblResult.Text = Class1.ToInt;
                }
            }
            else if (Class1.ResultParsed != 0)
            {
                if (Int64.TryParse(Class1.Result, out Class1.ResultNewParsed))
                {
                    Class1.FinalResult = Class1.ResultParsed * Class1.ResultNewParsed;
                    lblResult.Text = Convert.ToString(Class1.FinalResult);
                    Class1.Result = "0";
                }
                else
                {
                    lblResult.Text = Class1.ToInt;
                }
            }
            else
            {
                if (Int64.TryParse(Class1.Result, out Class1.ResultParsed))
                {
                    Class1.Result = "0";
                    lblResult.Text = Class1.Result;
                }
                else
                {
                    lblResult.Text = Class1.ToInt;
                }
            }
        }
        private void Divide()
        {
            if (Class1.FinalResultD != 0)
            {
                
                if (Class1.Result == "0")
                {
                    Class1.Reset();
                    lblResult.Text = Class1.Result;
                }





                if (Double.TryParse(Class1.Result, out Class1.ResultParsedD))
                {
                        Class1.FinalResultD = Class1.FinalResultD / Class1.ResultParsedD;
                        lblResult.Text = Class1.FinalResultD.ToString();
                        Class1.Result = "0";
                }
                else
                {
                    lblResult.Text = Class1.ToDouble;
                }
            }
            else if (Class1.ResultParsedD != 0)
            {
                
                if (Class1.Result == "0")
                {
                    Class1.Reset();
                    lblResult.Text = Class1.Result;
                }




                if (Double.TryParse(Class1.Result, out Class1.ResultNewParsedD))
                {
                        Class1.FinalResultD = Class1.ResultParsedD / Class1.ResultNewParsedD;
                        lblResult.Text = Class1.FinalResultD.ToString();
                        Class1.Result = "0";
                }
                else
                {
                    lblResult.Text = Class1.ToDouble;
                }
            }
            else if (Class1.Result.Contains(","))
            {
                if (Class1.Result == "0")
                {
                    Class1.Reset();
                    lblResult.Text = Class1.Result;
                }
                else if (Class1.FinalResult != 0)
                {
                    Class1.FinalResultToD = Convert.ToDouble(Class1.FinalResult);
                    if (Double.TryParse(Class1.Result,out Class1.ResultParsedD))
                    {
                        Class1.FinalResultD = Class1.FinalResultToD / Class1.ResultParsedD;
                        lblResult.Text = Class1.FinalResultD.ToString();
                        Class1.Result = "0";
                    }
                    else
                    {
                        lblResult.Text = Class1.ToDouble;
                    }
                    
                }
                else if (Class1.ResultParsed != 0)
                {
                    Class1.ResultParsedToD = Convert.ToDouble(Class1.ResultParsed);
                    if (Double.TryParse(Class1.Result, out Class1.ResultNewParsedD))
                    {
                        Class1.FinalResultD = Class1.ResultParsedToD / Class1.ResultNewParsedD;
                        lblResult.Text = Class1.FinalResultD.ToString();
                        
                        Class1.Result = "0";

                    }
                    else
                    {
                        lblResult.Text = Class1.ToDouble;
                    }
                }
                else if (Double.TryParse(Class1.Result, out Class1.ResultParsedD))
                {
                    Class1.Result = "0";
                    lblResult.Text = Class1.Result;
                }
                else
                {
                    lblResult.Text = Class1.ToDouble;
                }
            }
            else if (Class1.FinalResult != 0)
            {
                if (Class1.Result == "0")
                {
                    Class1.Reset();
                    lblResult.Text = Class1.Result;
                }


                if (Int64.TryParse(Class1.Result, out Class1.ResultParsed))
                {
                    Class1.FinalResultD = Class1.FinalResult / Class1.ResultParsed;
                    Class1.FinalDivString = Convert.ToString(Class1.FinalResultD);
                    if (Class1.FinalDivString.Contains(",0"))
                    {
                        //Add something to remove the ,0 from the string
                    }
                    lblResult.Text = Convert.ToString(Class1.FinalResult);
                    Class1.Result = "0";
                }
                else
                {
                    lblResult.Text = Class1.ToInt;
                }

            }   
            else if (Class1.ResultParsed != 0)
            {
                if (Class1.Result == "0")
                {
                    Class1.Reset();
                    lblResult.Text = Class1.Result;
                }

                if (Int64.TryParse(Class1.Result, out Class1.ResultNewParsed))
                {
                    Class1.FinalResultD = Class1.ResultParsed / Class1.ResultNewParsed;
                    //Not tested, changed FinalResult to D so output should always come as double
                    Class1.FinalDivString = Convert.ToString(Class1.FinalResultD);
                    if (Class1.FinalDivString.Contains(",0"))
                    {
                        //Add something to remove the ,0 from the string
                    }



                    lblResult.Text = Convert.ToString(Class1.FinalResult);
                    Class1.Result = "0";
                }
                else
                {
                    lblResult.Text = Class1.ToInt;
                }
            }
            else
            {
                if (Class1.Result == "0")
                {
                    Class1.Reset();
                    lblResult.Text = Class1.Result;
                }


                if (Int64.TryParse(Class1.Result, out Class1.ResultParsed))
                {
                    Class1.Result = "0";
                    lblResult.Text = Class1.Result;
                }
                else
                {
                    lblResult.Text = Class1.ToInt;
                }
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int x = 0;
            double y = 0;
            double z;

            if (true)
            {
                lblResult.Text = "Nothing to see here, move along!";
            }

            //remove the else so it works
            else if (y == 0)
            {
            Class1.Reset();
            if (!Class1.Result.Contains(","))
            {
                Class1.Result += ",0";
            }



            if (Double.TryParse(Class1.Result, out y))
            {
                Class1.Result = "0";
                lblResult.Text = Class1.Result;
            }
            else
            {
                lblResult.Text = Class1.ToDouble;
            }

                if (y != 0)
                {
                    if (Int32.TryParse(Class1.Result, out x))
                    {
                        Class1.Result = "0";
                        lblResult.Text = Class1.Result;
                    }
                    else
                    {
                        lblResult.Text = Class1.ToDouble;
                    }

                }
                


                for (int i = 1; i < x; i++)
                {

                }

            }

        }
    }

}