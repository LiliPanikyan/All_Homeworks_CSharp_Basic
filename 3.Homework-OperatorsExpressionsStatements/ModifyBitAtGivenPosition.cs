using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBitAtGivenPosition
{
    class ModifyBitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number:");
            int number = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a bit position that you want to change: ");
            int position = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the value you want to assign to the selected bits [0 or 1]: ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("Your number before modification in binary representation:\n " + Convert.ToString(number, 2).PadLeft(32, '0'));
            if (value == 1)
            {
                int setOne = 1 << position;
                int foundBitOne = number | setOne;
                Console.WriteLine("Your number after modifycation in binary representation:\n " + Convert.ToString(foundBitOne, 2).PadLeft(32, '0'));
                Console.WriteLine("After modification your number is: " + foundBitOne);
            }
            else
            {
                int setZero = ~(1 << position);
                int foundBitZero = number & setZero;
                Console.WriteLine("Your number after modifycation in binary representation:\n " + Convert.ToString(foundBitZero, 2).PadLeft(32, '0'));
                Console.WriteLine("After modification your number is: " + foundBitZero);
            }
            Console.ReadLine();
        }
    }
}

