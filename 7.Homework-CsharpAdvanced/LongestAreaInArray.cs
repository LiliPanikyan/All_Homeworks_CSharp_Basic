using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestAreaInArray
{
    class LongestAreaInArray
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter how many strings you want to use: ");
            int n = int.Parse(Console.ReadLine());
            string[] array = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("String :  ", i);
                array[i] = Console.ReadLine();

            }
            string strSame = array[0];
            Array.Sort(array);
            int same = 1;
            int longestLength = same;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    same++;
                }
                else
                {
                    same = 1;
                }
                if (longestLength < same)
                {
                    longestLength = same;
                    strSame = array[i];
                }
            }
            Console.WriteLine(longestLength);
            for (int i = 0; i < longestLength; i++)
            {
                Console.WriteLine(strSame);
            }
            Console.ReadLine();
        }
    }
}
