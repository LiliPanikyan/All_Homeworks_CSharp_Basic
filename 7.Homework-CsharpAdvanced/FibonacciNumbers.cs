using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Nth number:");
            int n = Int32.Parse(Console.ReadLine());
            Fib(n);
        }
        private static void Fib(int n)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine("Sum of numbers is: " + b);
            Console.ReadLine();
        }
    }
}
