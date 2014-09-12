using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2;
            Console.WriteLine("Enter Value in A: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value in B: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value in C: ");
            c = double.Parse(Console.ReadLine());
            double sqrtPart = (b * b - 4 * a * c);
            x1 = (-b + System.Math.Sqrt(sqrtPart)) / (2 * a);
            x2 = (-b - System.Math.Sqrt(sqrtPart)) / (2 * a);
            if ((b * b - 4 * a * c) < 0)
            {
                Console.WriteLine("There are no real roots!");
            }
            else
            {
                Console.WriteLine("Value of X1 is: " + x1);
                Console.WriteLine("Value of X2 is: " + x2);
            }
            Console.ReadLine();
        }
    }
}
