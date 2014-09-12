using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenProduct
{
    class OddEvenProduct
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number in a single line, separate by space: ");
            string userLine = Console.ReadLine();
            string[] masiv = userLine.Split(' ');

            int sumEven = 1;
            int sumOdd = 1;

            for (int i = 0; i < masiv.Length; i++)
            {
                int number = int.Parse(masiv[i]);
                if (i % 2 == 0)
                {
                    sumEven *= number;
                }
                else
                {
                    sumOdd *= number;
                }
            }
                if(sumEven == sumOdd)
            {
                Console.WriteLine("Equal product = " + sumEven);
                
            }
            else
            {
                Console.WriteLine("No.Product is NOT equal. Odd product = {0}, Even product = {1}", sumOdd, sumEven);
            }
           
            Console.ReadLine();
        }
    }
}
