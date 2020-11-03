using System;

namespace calculator.Models
{
    static public class Mathematics
    {

        static public string Calc(float FNum, float SNum, string Operation)
        {
  
            switch (Operation)
            {
                case "+":
                    Operation = Sum(FNum, SNum);
                    break;
                case "-":
                    Operation = Mathematics.Diff(FNum, SNum);
                    break;
                case "*":
                    Operation = Mathematics.Mult(FNum, SNum);
                    break;
                case "/":
                    Operation = Mathematics.Div(FNum, SNum);
                    break;
            }

            return Operation;
            
        }
        
        static public string Sum(float a, float b)
        {
            return Convert.ToString(a + b);
        }
        static public string Mult(float a, float b)
        {
            return Convert.ToString(a * b);
        }
        static public string Diff(float a, float b)
        {
            return Convert.ToString(a - b);
        }
        static public string Div(float a , float b)
        {
            if (b == 0) return "Error Div 0";
            return Convert.ToString(a / b);
        }
    }
}