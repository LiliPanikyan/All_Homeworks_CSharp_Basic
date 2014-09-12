using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNames
{
    class CountNames
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter list of words in a sigle line, separate by spase: ");
            string inputString = Console.ReadLine();
            List<string> wordList = inputString.Split(' ').ToList();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (string word in wordList)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }
                else
                {
                    dictionary[word] = 1;
                }
            }
            var list = dictionary.Keys.ToList();
            list.Sort();
            foreach (var key in list)
            {
                Console.WriteLine("{0}: {1}", key, dictionary[key]);
            }
            Console.ReadKey();  
        }
    }
}
