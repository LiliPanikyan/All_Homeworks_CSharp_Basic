using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  start number: ");
            int startNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter end number: ");
            int endNumber = Int32.Parse(Console.ReadLine());
            List<int> primes = IsPrime(startNumber, endNumber);

            foreach (int prime in primes)
            {
                Console.Write(prime + ",");
            }
            Console.ReadLine();
        }
        public static List<int> IsPrime(int start, int end)
        {
            List<int> primes = new List<int>();
                if (start < 2)
                 {
                     start = 2;
                 }
                 for (int i = start; i <= end; i++)
                 {
                     bool isPrime = true;
                     for (int j = 2; (j * j) <= i; j++)
                     {
                         if ((i % j) == 0)
                         {
                             isPrime = false;
                             break;
                         }
                     }
                     if (isPrime)
                     {
                         primes.Add(i);
                     }
                     
                 }
                 return primes;
                    
        }
        
    }
}
            