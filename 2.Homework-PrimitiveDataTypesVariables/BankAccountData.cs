using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main()
        {
            Console.WriteLine("Account details");
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your middle name");
            string middleName = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lastName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Customer: {0} {1} {2}", firstName, middleName, lastName);
            string theNameOfTheBank = "PostBank";
            Console.WriteLine("Bank: {0}", theNameOfTheBank);
            
            string iBan = "BGN07FFUU87003456735671";
            Console.WriteLine("IBAN: {0}", iBan);
            string bicCode = "BIC43562";
            Console.WriteLine("BIC CODE: {0}", bicCode);
            decimal balanceOfMoney = 2000;
            Console.WriteLine("Account balance: {0}lv", balanceOfMoney);
            ulong visaCard = 4346709612345976;
            Console.WriteLine("Visa card: {0}", visaCard);
            ulong masterCard = 1199886543214587;
            Console.WriteLine("Master card: {0}", masterCard);
            ulong expresCard = 5432156789004012;
            Console.WriteLine("Expres card: {0}", expresCard);
            Console.ReadLine();
        }
    }
}
