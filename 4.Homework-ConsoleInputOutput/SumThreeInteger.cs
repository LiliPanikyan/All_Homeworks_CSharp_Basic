using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumThreeInteger
{
    class SumThreeInteger
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculate a sum of three integer number.");
            Console.WriteLine("Please enter your first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your third number: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int sum = a + b + c;
            Console.WriteLine("Your result is: " + sum);
            Console.ReadLine();
        }
    }
}
