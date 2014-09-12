using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimalNumber
{
    class BinaryToDecimalNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Binary Number(1s and 0s) : ");
            string bin = Console.ReadLine();
            long l = Convert.ToInt64(bin, 2);
            Console.WriteLine("Decimal form is: " + l);
            Console.ReadLine();
        }
    }
}