using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            Console.WriteLine("Program gets two numbers from the console and prints the greater of them.");
            Console.WriteLine("Please enter first number: ");
            string strA = Console.ReadLine();
            decimal a = decimal.Parse(strA);
            Console.WriteLine("Please enter second number: ");
            string strB = Console.ReadLine();
            decimal b = decimal.Parse(strB);
            decimal greaterNumber = Math.Max(a, b);
            Console.WriteLine("Greater number is: {0}", greaterNumber);
            Console.ReadLine();
        }
    }
}
 