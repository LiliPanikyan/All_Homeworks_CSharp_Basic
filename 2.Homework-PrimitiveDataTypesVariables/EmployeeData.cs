using System;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            Console.WriteLine("Employee Data");
            string firstName = "Ivan";
            string lastname = "Ivanov";
            byte age = 28;
            char gender = 'M';
            long idNumber = 8306112507;
            int uniqueEmployeeNumber = 27560000;

            Console.WriteLine("First name:" + firstName);
            Console.WriteLine("Last name:" + lastname);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Gender:" + gender);
            Console.WriteLine("Personal ID number:" + idNumber);
            Console.WriteLine("Unique employee number:" + uniqueEmployeeNumber);
            Console.ReadLine();
            
        }
    }
}
