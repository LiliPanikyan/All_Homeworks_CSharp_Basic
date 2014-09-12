using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNames
{
    class RemoveNames
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First list of names (Please write in a single line, separate by space.): ");
            string strFirst = Console.ReadLine();
            string[] firstNames = strFirst.Split(' ');
            Console.WriteLine("Second list of names : ");
            string strSecond = Console.ReadLine();
            string[] secondNames = strSecond.Split(' ');

            List<string> firstLine = firstNames.ToList<string>();
            List<string> secondLine = secondNames.ToList<string>();
            for (int i = 0; i < secondLine.Count; i++)
            {
                for (int j = 0; j < firstLine.Count; j++)
                {
                    if (firstLine.Contains(secondLine[i]))
                    {
                        firstLine.Remove(secondLine[i]);
                    }
                }
            }

            foreach (var item in firstLine)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

