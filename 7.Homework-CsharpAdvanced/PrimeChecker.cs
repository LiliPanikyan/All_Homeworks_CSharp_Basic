using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number for check: ");
            int a = int.Parse(Console.ReadLine());
            bool isPrime = true;
            IsPrimeNumber(a, isPrime);
        }
        static void IsPrimeNumber(int a, bool isPrime)
        {
            int factor = a / 2;
            for (int i = 2; i <= factor; i++)
            {
                if ((a % i) == 0)
                {
                    isPrime = false;
                }
            }
            if (isPrime == true)
            {
                Console.WriteLine("Your number is Prime.");
            }
            else
            {
                Console.WriteLine("Your number is NOT Prime.");
            }
            Console.ReadLine();
        }
        
    }
    
}