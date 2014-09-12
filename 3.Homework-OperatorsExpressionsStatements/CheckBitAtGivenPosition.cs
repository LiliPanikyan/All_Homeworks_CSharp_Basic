using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBitAtGivenPosition
{
    class CheckBitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number:");
            String str = Console.ReadLine();
            Console.WriteLine("Enter a position of a bit:");
            string value = Console.ReadLine();
            int n = Int32.Parse(str);
            int p = Int32.Parse(value);
            int nRightP = n >> p;
            int bit = nRightP & 1;
            bool test = (bit == 1);
            if (test == true)
            {
                Console.WriteLine("Third bit in your number is 1.");
            }
            else
            {
                Console.WriteLine("Is NOT 1. Is 0.");
            }  
                Console.ReadLine();
        }
    }
}
