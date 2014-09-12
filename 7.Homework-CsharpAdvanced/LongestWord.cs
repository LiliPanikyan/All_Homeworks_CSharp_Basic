using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord
{
    class LongestWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter list of words in a sigle line, separate by spase: ");
            string inputString = Console.ReadLine();
            string[] wordList = inputString.Split(new char[] { ' ', ',', ':', ';', '.' },StringSplitOptions.RemoveEmptyEntries);
            int longestIndex = 0;
            for (int i = 1; i < wordList.Length; i++)
            {
                if (wordList[i].Length > wordList[longestIndex].Length)
                {
                    longestIndex = i;
                }
            }
            Console.WriteLine(wordList[longestIndex]);
            Console.ReadLine();
        }
    }
}
