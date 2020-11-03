using System;
using Avalonia.Markup.Xaml.Templates;
using Microsoft.VisualBasic;
using SharpDX.Direct3D11;
using SharpDX.WIC;

namespace calculator.Models
{
    static public class BinaryMathematics
    {
        static public string Inversiya(string MainStr)
        {
            for (int i = 0; i < MainStr.Length; i++)
            {
                if (MainStr[i] == '1')
                    MainStr = MainStr.Remove(i, 1).Insert(i, "0");
                else
                    MainStr = MainStr.Remove(i, 1).Insert(i, "1");
            }
            return MainStr;
        }

        static public string Calc(string FirstNum, string SecontNum, string Operation)
        {
            if (FirstNum.Length < SecontNum.Length)
            {
                for (int i = 0, len = FirstNum.Length; i < SecontNum.Length - len; i++)
                    FirstNum = "0" + FirstNum;
            }
            else
            {
                for (int i = 0, len = SecontNum.Length; i < FirstNum.Length - len ; i++)
                    SecontNum = "0" + SecontNum;
            }
            
            switch (Operation)
            {
                case "+":
                    FirstNum = BinSum(FirstNum, SecontNum);
                    break;
                case "*":
                    Operation = BinMult(FirstNum, SecontNum);
                    break;
            }
            return FirstNum;
        }

        static public string BinSum(string a, string b)
        {
            int OneVirt = 0;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                int sum = int.Parse(a[i].ToString()) + int.Parse(b[i].ToString()) + OneVirt;
                if(sum == 0)
                {
                    a = a.Remove(i, 1).Insert(i, "0");
                    OneVirt = 0;
                }
                else if(sum == 1)
                {
                    a = a.Remove(i, 1).Insert(i, "1");
                    OneVirt = 0;
                }
                else if (sum == 2)
                {
                    a = a.Remove(i, 1).Insert(i, "0");
                    OneVirt = 1;
                }
                else if(sum == 3)
                {
                    a = a.Remove(i, 1).Insert(i, "1");
                    OneVirt = 1;
                }
            }
            
            if (OneVirt == 1)
                a = '1' + a;
            return a;
        }

        static public string BinMult(string a, string b)
        {

            
            
            return a;
        }
    }
}