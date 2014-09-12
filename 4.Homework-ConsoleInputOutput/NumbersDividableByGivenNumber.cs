using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersDividableByGivenNumber
{
    class NumbersDividableByGivenNumber
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a number A: ");
            int numberA = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please eneter your second number B (! Number B should be grater than number A!):");
            int numberB = Int32.Parse(Console.ReadLine());
            int count = 0;
            for (int i = numberA; i <= numberB; i++)
            {
                if (i % 5 == 0)
                {
                   count++;
                }
            }
            Console.WriteLine("Dividable numbers by five between {0} and {1} are {2}.", numberA, numberB, count);
            Console.ReadLine();
        }
    }
}
