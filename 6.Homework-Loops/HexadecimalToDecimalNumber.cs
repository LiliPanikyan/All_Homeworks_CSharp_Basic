using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToDecimalNumber
{
    class HexadecimalToDecimalNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hexadecimal value: " );
            string strHex = Console.ReadLine();
            long decNumber = long.Parse(strHex, NumberStyles.HexNumber);
            Console.WriteLine("Decimal value of your hex value is: "+ decNumber);
            Console.ReadLine();

        }
    }
}
