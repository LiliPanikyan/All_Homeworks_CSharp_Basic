using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many numbers you want to sum: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter number: ");
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine("The sum is: {0}", sum);
            Console.ReadLine();
        }
    }
}
