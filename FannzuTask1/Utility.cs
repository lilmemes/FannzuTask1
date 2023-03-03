using System;

namespace FannzuTask1
{
    public class Utility
    {
        public static void PrintLog(string m)
        {
            Console.WriteLine(m); 
        }

        public static string ReverseString(string initialString)
        {
            string result = string.Empty;

            for (int i = initialString.Length - 1; i >= 0; i--)
            {
                result += initialString[i].ToString();
            };

            return result;
        }
    }
}
