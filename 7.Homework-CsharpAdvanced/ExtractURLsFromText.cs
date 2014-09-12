using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractURLsFromText
{
    class ExtractURLsFromText
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text: ");
            string mystring = Console.ReadLine();
            List<string> list = new List<string>();
            Regex urlRx = new
            Regex(@"(?<url>(http:|https:[/][/]|www.)([a-z]|[A-Z]|[0-9]|[/.]|[~])*)",
            RegexOptions.IgnoreCase);
            MatchCollection matches = urlRx.Matches(mystring);
            foreach (Match match in matches)
            {
                list.Add(match.Value);
                Console.WriteLine(match);
            }
            Console.ReadLine();
        }
    }
}
