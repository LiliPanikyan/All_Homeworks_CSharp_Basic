using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TrailingZeroes
{
    class TrailingZeroes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            string number = Console.ReadLine();
            int n = Int32.Parse(number);
            
            BigInteger factorial = 1;

            if (n >= 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }
            }
            Console.WriteLine("Trailing zeroes in N! are {0} ", (n / 5));
            Console.ReadLine();
        }
    }
}
