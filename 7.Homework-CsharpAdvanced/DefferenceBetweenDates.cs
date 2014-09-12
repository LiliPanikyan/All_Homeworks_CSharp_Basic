using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefferenceBetweenDates
{
    class DefferenceBetweenDates
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your two date's in a separate line (dd.MM.yyyy): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            DateTime endDate = DateTime.Parse(Console.ReadLine());
            double days = CountDays(startDate, endDate);

            Console.WriteLine("Days between: {0}", days);
            Console.ReadLine();
        }
        private static double CountDays(DateTime start, DateTime end)
        {
            TimeSpan span = end - start;
            double defference = span.TotalDays;

            return defference;
        }
    }
}
