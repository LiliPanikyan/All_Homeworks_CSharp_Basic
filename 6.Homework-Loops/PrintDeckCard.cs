using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDeckCard
{
    class PrintDeckCard
    {
        static void Main(string[] args)
        {
            char hearts = (char)3;
            char diamonds = (char)4;
            char spades = (char)5;
            char clubs = (char)6;
                Console.WriteLine("2{0} 2{1} 2{2} 2{3}", spades, diamonds, hearts, clubs);
                Console.WriteLine("3{0} 3{1} 3{2} 3{3}", spades, diamonds, hearts, clubs);
                Console.WriteLine("4{0} 4{1} 4{2} 4{3}", spades, diamonds, hearts, clubs);
                Console.WriteLine("5{0} 5{1} 5{2} 5{3}", spades, diamonds, hearts, clubs);
                Console.WriteLine("6{0} 6{1} 6{2} 6{3}", spades, diamonds, hearts, clubs);
                Console.WriteLine("7{0} 7{1} 7{2} 7{3}", spades, diamonds, hearts, clubs);
                Console.WriteLine("8{0} 8{1} 8{2} 8{3}", spades, diamonds, hearts, clubs);
                Console.WriteLine("9{0} 9{1} 9{2} 9{3}", spades, diamonds, hearts, clubs);
                Console.WriteLine("10{0} 10{1} 10{2} 10{3}", spades, diamonds, hearts, clubs);
                Console.WriteLine("J{0} J{1} J{2} J{3}", spades, diamonds, hearts, clubs);
                Console.WriteLine("Q{0} Q{1} Q{2} Q{3}", spades, diamonds, hearts, clubs);
                Console.WriteLine("K{0} K{1} K{2} K{3}",spades, diamonds, hearts, clubs);
                Console.WriteLine("A{0} A{1} A{2} A{3}", spades, diamonds, hearts, clubs);
                Console.ReadLine();      
        }
    }
}
