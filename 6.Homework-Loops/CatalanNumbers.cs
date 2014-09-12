using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            // Cn = (2n)! / ((n+1)!*n!)
            Console.WriteLine("Enter number N : ");
            string srtN = Console.ReadLine();
            int n = Int32.Parse(srtN);
            double factN = 1;
            double factTwoN = 1;
            int first = 2 * n;
            int second = n + 1;
            double factPlusOne = 1;
            double result = 0;
            if (1 < n && n < 100)
            {
                for (int i = 1; i <= n; i++)
                {
                    factN *= i;
                }
                for (int y = 1; y <= first; y++)
			    {
                    factTwoN *= y;
			    }
                for (int j = 1; j <= second; j++)
                {
                    factPlusOne *= j;
                }
                result = (factTwoN / (factPlusOne * factN));
                Console.WriteLine("Result is : " + result );
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
            Console.ReadLine();
        }
    }
}
