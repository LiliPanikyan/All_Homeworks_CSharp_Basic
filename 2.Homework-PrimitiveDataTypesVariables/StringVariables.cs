using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringVariables
{
    class StringVariables
    {
        static void Main(string[] args)
        {
            string text = "Hello";
            string word = "World";
            object allText = text + " " + word + "!";
            string textString = allText.ToString();
            Console.WriteLine(textString);
            Console.ReadLine();
        }
    }
}