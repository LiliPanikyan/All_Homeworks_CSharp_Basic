using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AscllCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            char symbol;
            for (int i = 0; i <= 255; i++)
            {
                symbol = (char)i;
                Console.WriteLine("{0} -> {1}", i, symbol);
            }
            Console.ReadLine();
        }
    }
}
