using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    internal class CalculatingWithDateTime
    {
        public CalculatingWithDateTime() {
            DateTime thisYear = new DateTime(2024, 4, 8);
            bool isLeapYear = DateTime.IsLeapYear(thisYear.Year);

            DateTime thisMoment = DateTime.Now;
            DateTime anHourFromNow = thisMoment.AddHours(1);

            int year = DateTime.Now.Year;                       // for example 2023
            DayOfWeek dayOfWeek = DateTime.Now.DayOfWeek;       // for example monday

            DateTime date = DateTime.Today;                 // Get just the date part
            TimeSpan time = thisMoment.TimeOfDay;           // Get just the time part
            TimeSpan duration = new TimeSpan(3, 0, 0, 0);   // Specify length in days
            DateTime threeDaysFromNow = thisMoment.Add(duration);

            TimeSpan duration1 = new TimeSpan(1 , 0 , 0); // One hour later
            // Since Today gives 12:00:00 AM, the following gives 1:00:00 AM
            DateTime anHourAfterMidnight = DateTime.Today.Add(duration1);
            //Console.WriteLine("An hour after Midnight will be {0}", anHourAfterMidnight);
            DateTime midnight = anHourAfterMidnight.Subtract(duration1);
            //Console.WriteLine("An hour before 1 AM is {0}", midnight);

            //Console.WriteLine(duration);
        }
    }
}
