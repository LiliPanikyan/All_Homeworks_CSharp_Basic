using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateCombination
{
    class CalculateCombination
    {
        static void Main(string[] args)
        {
            //N! / (K! * (N-K)!)
            Console.WriteLine("Enter number N: ");
            string strN = Console.ReadLine();
            int n = int.Parse(strN);
            Console.WriteLine("Enter number K: ");
            string strK = Console.ReadLine();
            int k = int.Parse(strK);
            double factN = 1;
            double factK = 1;
            double factNFactK = 1;
            double result = 0;
            double temp = n - k;
            if (1 < k && k < n && n < 100)
             {
                for (int i = 1; i <= n; i++)
                {
                    factN *= i;
                }
                for (int y = 1; y <= k; y++)
                {
                    factK *= y;
                }
                for (int j = 1; j <= temp; j++)
                {
                    factNFactK *= j;
                }
                result = factN / (factK * factNFactK);
                Console.WriteLine("The result of calculation is: {0}", result);
            }
            else
            {
                Console.WriteLine("Invalid Number!");
            }
            
            Console.ReadLine();


        }
    }
}
