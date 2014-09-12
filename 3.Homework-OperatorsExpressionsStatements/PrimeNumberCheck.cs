using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a number ot find is it prime or not");
                int a = Int32.Parse(Console.ReadLine());
                bool bPrime = true;
                int factor = a / 2;
                
                for ( int i = 2; i <= factor; i++)
                {
                    if ((a % i) == 0)
                    {
                        bPrime = false;
                    }
                }
                if (bPrime == true)
                {
                    Console.WriteLine("Your number is Prime.");
                }
                else
                {
                    Console.WriteLine("Your number is NOT Prime.");
                }
            }
        }
    }
}
