using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInformation
{
    class CompanyInformation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company information");
            Console.WriteLine("Enter Company name: ");
            string company = Console.ReadLine();           
            Console.WriteLine("Company address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Phone number ( +359888888888): ");
            UInt64 number = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Fax number ( 027777777 ): ");
            UInt64 fax = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Web site C http://******.bg ): ");
            string web = Console.ReadLine();
            Console.WriteLine("Manager first name: ");
            string first = Console.ReadLine();
            Console.WriteLine("Manager last name: ");
            string last = Console.ReadLine();
            Console.WriteLine("Manager age: ");
            sbyte age = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Manager phone number ( +359888888888): ");
            UInt64 phone= Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine();
            Console.Write("{0}\nAddress: {1}\nPhone number: {2:(+###) ### ## ## ##} \nFax Number: {3:(0#) ### ## ##}\nWeb site: {4}\nManager: {5}" + " " + "{6}" + "(Age: {7}" + ",tel: {8:(+###) ### ## ## ##})", company, address, number, fax, web, first, last, age, phone);
            Console.ReadLine();
        }
    }
}
