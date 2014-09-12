using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Globalization;
using System.Collections.Concurrent;

namespace AverageLoadTimeCalculator
{
    class AverageLoadTimeCalculator
    {
        static void Main()
        {
            List<LoadTimeCalculator> report = new List<LoadTimeCalculator>();

            bool shouldConToEnter = true;
            while (shouldConToEnter == true)
            {
                Console.Write("Please enter url visit date: ");
                string urlVisitDateInput = Console.ReadLine();
                Console.Write("Please enter url address: ");
                string URLInput = Console.ReadLine();
                Console.Write("Please enter visit count for this url: ");
                string visitCountInput = Console.ReadLine();

                report.Add(new LoadTimeCalculator() { UrlVisitDate = DateTime.Parse(urlVisitDateInput), URL = URLInput, VisitCount = Double.Parse(visitCountInput) });

                Console.Write("Continue to enter recourds(yes:no): ");
                string answer = Console.ReadLine();
                if (answer == "no")
                {
                    shouldConToEnter = false;
                }
            }

            var groupReportList = report.GroupBy(x => x.URL).ToList();

            foreach(var item in groupReportList)
            {
                var singleItem = item.ToList().Where(x => x.URL == item.Key);
                var singleItemCount = singleItem.Average(x => x.VisitCount);
                Console.WriteLine(string.Format("Result: {0} -> {1}", item.Key, singleItemCount));
            }

            Console.ReadLine();
        }
    }

    public class LoadTimeCalculator
    {
        public DateTime UrlVisitDate { get; set; }

        public string URL { get; set; }

        public double VisitCount { get; set; }
    }
}
            
            
            
