using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetters
{
    class CountLetters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter list of letters in a sigle line, separate by spase: ");
            string inputString = Console.ReadLine();
            inputString = inputString.ToLower();
            List<string> letterList = inputString.Split(' ').ToList();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (string letter in letterList)
            {
                if ( dictionary.ContainsKey(letter) )
					{
						dictionary[letter]++;
					}
					else
					{
						dictionary[letter] = 1;
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