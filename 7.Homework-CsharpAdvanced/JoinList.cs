using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinList
{
    class JoinList
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter your first list of number in a single line, separate by space: ");
            string strFisrt = Console.ReadLine();
            string[] first = strFisrt.Split(' ');
            Console.WriteLine("Eneter your second list of number in a single line, separate by space: ");
            string strSecond = Console.ReadLine();
            string[] second = strSecond.Split(' ');

            List<int> allNumbers = new List<int>();
            for (int i = 0; i < first.Length; i++)
            {
                allNumbers.Add(int.Parse(first[i]));
            }
 
            for (int x = 0; x < second.Length; x++)
            {
                allNumbers.Add(int.Parse(second[x]));
            }
 
            allNumbers.Sort();
            allNumbers = allNumbers.Distinct().ToList();
            foreach (int number in allNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
