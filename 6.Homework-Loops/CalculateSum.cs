using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSum
{
    class CalculateSum
    {
        static void Main(string[] args)
        {
            //sum S = 1 + 1!/x + 2!/x2 + … + n!/xn
            Console.Write("Please enter number N:");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number X: ");
            int x = Int32.Parse(Console.ReadLine());

            double factorialN = 1;
            double sumFactorial = 0;
            if (n > 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    factorialN *= i;
                    sumFactorial = (1 + (factorialN / double.Parse(Math.Pow((int)x, (int)i).ToString())));
                }
                Console.WriteLine("Sum is: {0:F5}", sumFactorial);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            Console.ReadLine();

        }
    }
}

