using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseExtractBit3
{
    class BitwiseExtractBit3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will show you value of the bit #3 in your number.");
            Console.Write("Enter your number:");
            String str = Console.ReadLine();
            int n = Int32.Parse(str);
            int p = 3;
            int nRightP = n >> p;      
            int bit = nRightP & 1;     
            Console.WriteLine("Thirth bit in your number is: {0}", bit);    
            Console.ReadLine();
        }
    }
}
