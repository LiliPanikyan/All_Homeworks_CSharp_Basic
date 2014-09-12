using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFactorialNDivideByFactorialK
{
    class CalculateFactorialNDivideByFactorialK
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number N: ");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number K: ");
            double k = double.Parse(Console.ReadLine());

            double factorialN = 1;
            double factorialK = 1;
            double result = 0;
            if (1 < k && k < n && n < 100)
            {
                for (int i = 1; i <= n ; i++)
			    {
			        factorialN *= i;
			    }
		        for (int y = 1; y <= k; y++)
			    {
			        factorialK *= y;
			    }
                  
                result = factorialN / factorialK;
            }
            else   
	        {
                Console.WriteLine("Invalid input number!");
	        }
            Console.WriteLine("Result is: {0}", result);
            Console.ReadLine();
        }
    }
}
