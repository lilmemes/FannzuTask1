using System;
using System.Runtime.ConstrainedExecution;

namespace FannzuTask1
{
    public class Utility
    {

        public static int Sum(int s, int a)
        {
            return s + a;
        }

        public static int Minus(int s, int a)
        {
            return s - a;
        }

        public static int Multiply(int s, int a)
        {
            return s * a;
        }

        public static double Divide(double s, double a)
        {
            return s / a;
        }

        public static bool Equal(int s, int a)
        {
            return s == a;
        }

        public static int Pow(int s)
        {
            return s * s;
        }

        public static int Div(int s, int a)
        {
            return s % a;
        }

        public static void PrintLog(string ass)
        {
            Console.WriteLine(ass); 
        }

        public static string FirstCharToUpper(string initialString)
        {
            return initialString[0].ToString().ToUpper() + initialString.Substring(1);
        }

        public static string WholeTextToUpper(string initialString)
        {
            return initialString.ToUpper();
        }

        public static string CustomSubstring(string initialString, int n)
        {
            if (initialString.Length < n)
            {
                return "POWEL NAHUI";
            }

            return initialString.Substring(5, n);
        }
    }
}
