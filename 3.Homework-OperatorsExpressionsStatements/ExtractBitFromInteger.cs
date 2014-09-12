using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main(string[] args)
        {
            while (true)
            {
                byte p;
                int v;
                Console.Write("Enter the position of the bit:");
                bool ispByte = byte.TryParse(Console.ReadLine(), out p);
                Console.Write("Enter the integer number:");
                bool isvInt = int.TryParse(Console.ReadLine(), out v);
                string print = string.Empty;
                if (ispByte && isvInt && p < 32)
                {
                    int mask = 1 << p;
                    {
                        print = ((v & mask) == mask)? "Value of the bit is 1." : "Value of the bit is 0.";
                        Console.WriteLine(print);
                    }

                }
            }
        }
    }
}
