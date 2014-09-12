using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidArea
{
    class TrapezoidArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculate trapezoid's area.");
            Console.WriteLine("Enter trapezoid's side a: "); ;
            string strSideA = Console.ReadLine();
            double a = double.Parse(strSideA);
            Console.WriteLine("Enter trapezoid's side b: ");
            string strSideB = Console.ReadLine();
            double b = double.Parse(strSideB);
            Console.WriteLine("Enter trapezoid's height h: ");
            string strSideH = Console.ReadLine();
            double h = double.Parse(strSideH);
            Console.WriteLine("The area of the trapezoid is: " + (((a + b) / 2) * h));
            Console.ReadLine();
        }
    }
}
