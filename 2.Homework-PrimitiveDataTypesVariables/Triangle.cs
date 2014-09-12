using System;

namespace Triangle
{
    class Triangle
    {
        static void Main()
        {
            char copy = '\u00A9';
            Console.WriteLine("   " + copy);
            Console.WriteLine("  " + "{0}" + " " + "{0}", copy);
            Console.WriteLine(" " + "{0}" + "   " + "{0}", copy);
            Console.WriteLine("{0}" + " " + "{0}" + " " + "{0}" + " " + "{0}", copy);
            Console.ReadLine();
        }
    }
}
