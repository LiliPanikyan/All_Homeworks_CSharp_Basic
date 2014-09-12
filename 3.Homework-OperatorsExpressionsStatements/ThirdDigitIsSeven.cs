using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdDijitIsSeven
{
    static class ThirdDijitSeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This calculation will show if the third digit in your number is seven.");
            while (true)
            {
                Console.Write("Enter a number:");
                string inputValue = Console.ReadLine();
                string output = inputValue.Substring(inputValue.Length - 3, 3)[0].ToString();
                int intValue = Int32.Parse(output);
                if(intValue == 7)
                {
                    Console.WriteLine("Third number (from right to left) is 7");
                }
                else
                {
                    Console.WriteLine("Third number (from right to left) is NOT 7");
                }
            }
        } 
    }
}
