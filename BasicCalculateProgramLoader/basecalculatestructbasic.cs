using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculateProgramLoader
{
    public class basecalculatestructbasic
    {


        public static double Add(double leftVar, double rightVar)
        {
            return leftVar + rightVar;
        }

        public static double Sub(double leftVar, double rightVar)
        {
            return leftVar - rightVar;
        }

        public static double Mul(double leftVar, double rightVar)
        {
            return leftVar * rightVar;
        }

        public static double Div(double leftVar, double rightVar)
        {
            return leftVar / rightVar;
        }

        public static double Mod(double leftVar, double rightVar)
        {
            return leftVar % rightVar;
        }
        
        public static double ln(double vari)
        {
            return Math.Log(vari);
        }

        public static double log(double vari)
        {
            return Math.Log10(vari);
        }

        public static double Sin(double vari)
        {
            return Math.Sin(vari);
        }

        public static double Sinh(double vari)
        {
            return Math.Sinh(vari);
        }

        public static double Cos(double vari)
        {
            return Math.Cos(vari);
        }

        public static double Cosh(double vari)
        {
            return Math.Cosh(vari);
        }

        public static double Tan(double vari)
        {
            return Math.Tan(vari);
        }

        public static double Tanh(double vari)
        {
            return Math.Tanh(vari);
        }

        public static double XS(double vari)
        {
            return vari * vari;
        }

        public static double XQ(double vari)
        {
            return vari * vari * vari;
        }

        public static double Sqrt(double vari)
        {
            return Math.Sqrt(vari);
        }

        public static double Exp(double vari)
        {
            return Math.Exp(vari);
        }

        public static double Per(double vari)
        {
            return vari / 100;
        }

        public static double OBy(double vari)
        {
            return 1 / vari;
        }

        public static double PI()
        {
            return Math.PI;
        }

        public static string Dec(string vari)
        {
            return System.Convert.ToString(vari);
        }

        public static string Bin(string vari)
        {
            return System.Convert.ToString(int.Parse(vari), 2);
        }

        public static string Oct(string vari)
        {
            return System.Convert.ToString(int.Parse(vari), 8);
        }

        public static string Hex(string vari)
        {
            return System.Convert.ToString(int.Parse(vari), 16);
        }

    }
}
