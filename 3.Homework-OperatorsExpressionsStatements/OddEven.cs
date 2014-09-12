using System;

namespace OddEven
{
    class OddEven
    {
        static void Main()
        {
                Console.WriteLine("This program will show if your number is odd or even.");
            while (true)
            {
                Console.Write("Please enter your number:");
                string inputValue = Console.ReadLine();
                int result = 0;
                bool valid = Int32.TryParse(inputValue, out result);
                string print = string.Empty;
                if (valid == true)
                {
                    print = (result % 2 == 0) ? "Your number is even:" : "Your number is odd:";
                    Console.WriteLine(print);                   
                }
            }

        }
    }
}
