using System;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a four digit number:");
            int a, b, c, d;

            string inputValue = Console.ReadLine();
            a = Int32.Parse(inputValue[0].ToString());
            b = Int32.Parse(inputValue[1].ToString());
            c = Int32.Parse(inputValue[2].ToString());
            d = Int32.Parse(inputValue[3].ToString());

            Console.WriteLine("Your four dijit number in alphabet format is: " + ("abcd"));
            Console.WriteLine("The sum of digits is: " + (a + b + c + d));
            Console.WriteLine("Reversed format of your number is: {0}{1}{2}{3}{4} ", d, c, b, a, (" dcba"));
            Console.WriteLine("When i replace first digit whit last the result is: {0}{1}{2}{3}{4} ", d, a, b, c, (" dabc"));
            Console.WriteLine("When i exchange the second and the third digits the result is: {0}{1}{2}{3}{4}", a, c, b, d, (" acbd"));
            Console.ReadLine();
        }
    }
}
