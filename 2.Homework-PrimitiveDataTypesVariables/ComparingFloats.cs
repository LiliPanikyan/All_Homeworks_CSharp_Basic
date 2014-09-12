using System;
using System.Globalization;
using System.Threading;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            Console.WriteLine("This program compares floating-point numbers\n with precision eps = 0.000001");
            while (true)
            {
                Console.Write("Enter the first number: ");
                string val = Console.ReadLine();
                double firstNumber = double.Parse(val);
                Console.Write("Enter the second number: ");
                string num = Console.ReadLine();
                double secondNumber = double.Parse(num);
                float precision = 0.000001f;
                bool areEqual = (Math.Abs(firstNumber - secondNumber) < precision);

                Console.WriteLine(areEqual);
            }
        }
    }
}