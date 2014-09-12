using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWordInText
{
    class CountWordInText
    {
        static void Main(string[] args)
        {
            Console.Write("Your word: ");
            string strWord = Console.ReadLine();
            strWord = strWord.ToLower();
            Console.WriteLine("Write your text: ");
            string strText = Console.ReadLine();
            string[] list = strText.Split(' ');
            int counter = 0;
            foreach (string word in list)
            {
                if (word.ToLower() == strWord.ToLower())
                {
                    counter++;
                }
            }
            Console.WriteLine("'{0}' occurs {1} times in the given text.", strWord, counter);
            Console.ReadLine();
        }
    }
}
