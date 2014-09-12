using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program finds the biggest of five numbers. ");
            Console.WriteLine("Enter five numbers in a separate line: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double[] numbers = new double[] { a, b, c, d, e };
            Console.WriteLine("Bigest number is: " + numbers.Max());
            Console.ReadLine();
        }
    }
}
