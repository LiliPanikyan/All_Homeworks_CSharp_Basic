using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSumAverage
{
    class MinMaxSumAverage
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers you will use: ");
            int length = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            double sum = 0;
            double avg = 0;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter your numbers: ");
                int number = int.Parse(Console.ReadLine());
                min = Math.Min(min, number);
                max = Math.Max(max, number);
                sum += number;
                avg = sum / length;
            }
            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = {0:f2}", avg);
            Console.ReadLine();


        }
    }
}