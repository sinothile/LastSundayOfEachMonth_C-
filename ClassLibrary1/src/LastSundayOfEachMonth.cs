using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class LastSundayOfEachMonth
    {
        public List<string> GetLastSunday(int year)
        {
            DateTime date = new DateTime(year, 1, 1);
            List<string> ListOfsundays = new List<string>();

            while (YearIsEqualToReceivedYear(year, date))
            {
                if (DayOfTheWeekIsLastSundayOfTheMonth(year, date))
                    ListOfsundays.Add(date.ToString("yyyy-MM-dd"));
                    date = date.AddDays(1);
            }
            return ListOfsundays.ToList();

        }

        private static bool YearIsEqualToReceivedYear(int year, DateTime date)
        {
            return date.Year == year;
        }

        private static bool DayOfTheWeekIsLastSundayOfTheMonth(int year, DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Sunday && date.Day > (DateTime.DaysInMonth(year, date.Month) - 7);
        }
    }
}
