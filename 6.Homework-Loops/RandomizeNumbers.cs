using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeNumbers
{
    class RandomizeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int n = Int32.Parse(Console.ReadLine());

            Random numbers = new Random();
            for (int i = 1; i <= n; i++)
            {
                int randomNumber = numbers.Next(n);
                Console.Write(randomNumber);
            }
            Console.ReadLine();
        }
    }
}
