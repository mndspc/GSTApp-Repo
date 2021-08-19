using System;
using GST;

namespace GSTAppWithConsole
{
    class Program
    {
        //  This program demo. how consume classes from .dll/private assembly
        static void Main(string[] args)
        {
            Console.Write("Enter your Product Amount:");
            double proAmt = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter GST Per:");
            double gstPer = Convert.ToDouble(Console.ReadLine());
            GSTCalc gSTCalc = new GSTCalc(proAmt, gstPer);
            Console.WriteLine("Product Amount with GST is:{0}", gSTCalc.AmtIncludingGst());
            Console.ReadLine();
        }
    }
}
