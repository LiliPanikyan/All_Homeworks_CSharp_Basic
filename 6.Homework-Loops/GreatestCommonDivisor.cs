using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number A: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter number B : ");
            int b = Int32.Parse(Console.ReadLine());
            int remain = 1;
            while (a > 0 && b > 0)
            {
                remain = a % b;
                a = b;
                b = remain;
            }
            Console.WriteLine("Greatest common divisor is : {0}",Math.Abs(a));
            Console.ReadLine();
        }
    }
}
