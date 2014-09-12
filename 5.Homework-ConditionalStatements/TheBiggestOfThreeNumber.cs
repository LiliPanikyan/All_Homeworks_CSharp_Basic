using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggestOfThreeNumber
{
    class TheBiggestOfThreeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("That program finds the biggest of three numbers");
            Console.WriteLine("Please enter first number: ");
            string strA = Console.ReadLine();
            float a = float.Parse(strA);
            Console.WriteLine("Please enter second number: ");
            string strB = Console.ReadLine();
            float b = float.Parse(strB);
            Console.WriteLine("Please enter third number: ");
            string strC = Console.ReadLine();
            float c = float.Parse(strC);
            if (a == b && b == c)
            {
                Console.WriteLine("Your numbers is equal.");
            }
            else
            {
                Console.Write("Bigest number is: " + (Math.Max(Math.Max(a, b), c)));
            }
            Console.ReadLine();
        }
    }
}
