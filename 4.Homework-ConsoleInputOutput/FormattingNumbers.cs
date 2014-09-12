using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer 'A' number (0 ≤ a ≤ 500): ");
            string strA = Console.ReadLine();
            int a = int.Parse(strA);
            Console.WriteLine("Please enter an floating-point 'B' number: ");
            string strB = Console.ReadLine();
            float b = float.Parse(strB);
            Console.WriteLine("Please enter an floating-point 'C'number: ");
            string strC = Console.ReadLine();
            float c = float.Parse(strC);
            string aColumn = string.Format("|{0,-10:X2}|", a);
            string bColumn = string.Format("{0,-10}|",(Convert.ToString(a, 2).PadLeft(10, '0')),a);
            string cColumn = string.Format("{0,10:F2}|", b);
            string dColumn = string.Format("{0,-10:F3}",c);
            Console.WriteLine(aColumn + bColumn + cColumn + dColumn);
            Console.ReadLine();
        }
    }
}
