using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program reads a number N and prints on the console\nthe first N members of the Fibonacci sequence.");
            Console.WriteLine("Enter Nth number:");
            int n = Int32.Parse(Console.ReadLine());
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
            Console.ReadLine();
        }
    }
}
