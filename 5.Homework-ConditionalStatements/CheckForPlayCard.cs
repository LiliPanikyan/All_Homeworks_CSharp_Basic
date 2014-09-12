using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForPlayCard
{
    class CheckForPlayCard
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Check fo valid play card.");
            Console.WriteLine("Enter play card numbers or capital leters A,J,K,Q: ");
            while (true)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "10":
                    case "J":
                    case "Q":
                    case "K":
                    case "A":
                        Console.WriteLine("Yes.Valid card.");
                        break;
                    default:
                        Console.WriteLine("No.Not valid card.");
                        break;
                }
            }
            }
        }
    }

