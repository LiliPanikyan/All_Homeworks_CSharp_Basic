using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithIntDoubleString
{
    class PlayWithIntDoubleString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type 1 for int, 2 for double or 3 for string:");
            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    Console.WriteLine("Please enter int number:");
                    int number = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(number + 1);
                    break;
                case "2":
                    Console.WriteLine("Please enter double number:");
                    double dblNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine(dblNumber + 1);
                    break;
                case "3":
                    Console.WriteLine("Please enter a string:");
                    string str = Console.ReadLine();
                    Console.WriteLine(str + "*");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
            Console.ReadLine();
        }
    }
}
