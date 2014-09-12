using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number n for range: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Min = ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Max = ");
            int max = int.Parse(Console.ReadLine());
            if (min < max)
            {
                Random numbers = new Random();
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(numbers.Next(min, max + 1) + " ");
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            Console.ReadLine();
        }
    }
}
