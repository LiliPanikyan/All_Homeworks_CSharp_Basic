using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your intiger number: ");
            long number = long.Parse(Console.ReadLine());
            if (number >= 0)
            {
                Console.WriteLine("Your number in binary representation is :\n " + Convert.ToString(number, 2).PadLeft(32, '0'));
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            Console.ReadLine();
        }
    }
}
