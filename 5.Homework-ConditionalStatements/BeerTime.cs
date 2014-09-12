using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace BeerTime
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter time, hour and minute with following format HH:MM and PM or AM!");
            string str =Console.ReadLine();
            DateTime temp = DateTime.Now;
            string[] timeParts = str.Split(':');
            int hours = int.Parse(timeParts[0].ToString());
            int minute = int.Parse(timeParts[1].Split(' ')[0].ToString());
            string dayPart = timeParts[1].Split(' ')[1];
            DateTime startTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 13, 0, DateTime.Today.Second);
            DateTime endTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day+1, 3, 0, DateTime.Today.Second);
            DateTime searchTime = DateTime.Today;
            if (dayPart == "AM")
            {
                searchTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day + 1, hours, minute, DateTime.Today.Second);
            }

            if (dayPart == "PM")
            {
                searchTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, hours + 12, minute, DateTime.Today.Second);
            }

            if( startTime <= searchTime && searchTime <= endTime)
            {
                Console.WriteLine("Beer Time");
            }
            else
            {
                Console.WriteLine("It's NOT a Beer Time");
            }
            Console.ReadLine();
        }      
    }
}
