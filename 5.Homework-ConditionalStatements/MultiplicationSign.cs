using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            Console.WriteLine("Program shows the sign (+, - or 0) of the product of three real numbers");
            Console.WriteLine("Please enter your number in separate line: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("The product is zero");
            }
            else if (a < 0 && b < 0 && c > 0)
            {
                Console.WriteLine("The product is positive");
            }
            else if(a < 0 && b > 0 && c < 0)
            {
                Console.WriteLine("The product is positive");
            }
            else if(a > 0 && b < 0 && c < 0)
            {
                Console.WriteLine("The product is positive");
            }
            else if (a < 0 || b < 0 || c < 0)
            {
                Console.WriteLine("The product is negative");
            }
            else
            {
                Console.WriteLine("The product is positive");
            }
            Console.ReadLine();
        }
    }
}