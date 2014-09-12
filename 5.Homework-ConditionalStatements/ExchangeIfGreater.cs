using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program takes two integer variables A and B and prints them in ascending order");
            Console.WriteLine("Please enter your first number A: ");
            string strA = Console.ReadLine();
            decimal a = Convert.ToDecimal(strA);
            Console.WriteLine("Please enter your first number B: ");
            string strB = Console.ReadLine();
            decimal b = Convert.ToDecimal(strB);
            if (a==b)
            {
                Console.WriteLine("Your numbers are equal."); 
            }
            if (a < b)
            {
                Console.WriteLine(a + " " + b);
            }
            else
            {
                Console.WriteLine(b + " " + a);
            }
            Console.ReadLine();
        }
    }
}
