using System;

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            int x = 5;
            int y = 10;
            Console.WriteLine("Before: x = {0}: y = {1}", x, y);
            Console.WriteLine();
            
            y = y - x;
            x = x + x;
            Console.WriteLine("After: x = {0}: y = {1}", x, y);
            Console.ReadLine();
        }
    }
}
