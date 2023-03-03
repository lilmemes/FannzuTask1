using System;

namespace FannzuTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 97;
            double b = (double)a;

            Utility.PrintLog(b.ToString());

            string c = Convert.ToString(b);
            c = Utility.ReverseString(c);

            Utility.PrintLog(c.ToString());

            int d = Convert.ToInt32(c);
            char e = (char)d;

            Utility.PrintLog(e.ToString());

            Console.ReadLine();
        }
    }
}
