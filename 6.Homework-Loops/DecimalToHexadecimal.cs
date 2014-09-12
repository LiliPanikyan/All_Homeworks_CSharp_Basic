using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a integer number: ");
            long number = long.Parse(Console.ReadLine());
            if (number > 0)
            {
                string hex = string.Format("{0:X2}", number);
                Console.WriteLine("Hexadecimal representation {0} .", hex);
            }
            else
            {
                Console.WriteLine("Invalid number! ");
            }
            Console.ReadLine();
        }
    }
}
