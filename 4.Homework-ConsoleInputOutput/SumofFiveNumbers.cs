using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofFiveNumbers
{
    class SumofFiveNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programe calculates and prints sum of a 5 numbers.");
            Console.WriteLine("Please enter 5 number in a separate line: ");
            decimal dcmA = decimal.Parse(Console.ReadLine());
            decimal dcmB = decimal.Parse(Console.ReadLine());
            decimal dcmC = decimal.Parse(Console.ReadLine());
            decimal dcmD = decimal.Parse(Console.ReadLine());
            decimal dcmE = decimal.Parse(Console.ReadLine());
            decimal sum = dcmA + dcmB + dcmC + dcmD + dcmE;
            Console.WriteLine("The sum of your numbers {0} {1} {2} {3} {4} is: {5}", dcmA, dcmB, dcmC, dcmD, dcmE, sum);
            Console.ReadLine(); 
        }
    }
}
