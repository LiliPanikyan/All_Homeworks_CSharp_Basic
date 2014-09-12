using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace SortingNumbers
{
    class SortingNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter how many numbers you want to use: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("number =  ", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array array = numbers;
            Array.Sort(numbers);
            Console.WriteLine("Sorted numbers: ");
            foreach (int value in numbers)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
