using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersnotDivisibleByThreeAndSeven
{
    class NumbersNotDivisibleByThreeAndSeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive intiger number: ");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}

