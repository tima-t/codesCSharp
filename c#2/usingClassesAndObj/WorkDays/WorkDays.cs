using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDays
{
    class WorkDays
    {
        static void Main()
        {
             List<DateTime> holidays = new List<DateTime>()
            {new DateTime(2015, 3, 1),new DateTime(2015, 3, 3),new DateTime(2015, 4, 2),
            new DateTime(2015, 4, 10), new DateTime(2015, 5, 2),new DateTime(2015, 5, 12),new DateTime(2015, 12, 31),new DateTime(2015, 12, 24),new DateTime(2015, 4, 12)};
            Console.Write(" write the date you want  on a single line in format yyyy-month-day and use current year : " );
            string[] seps = { "-", "" };
            string[] date = (Console.ReadLine()).Split(seps, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("the work days are {0}", WorkDayss(new DateTime(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2])), holidays));


            
        }

        public static int WorkDayss(DateTime someDate,List<DateTime> holidays)
        {
            DateTime startDate = DateTime.Now;
            int workDays = 0;
            int celebrations = 0;
            int weekends = 0;
            while (startDate < someDate)
            {
                if (holidays.Contains(startDate))
                {
                    celebrations++;
                }
                if ((int)startDate.DayOfWeek == 0 || (int)startDate.DayOfWeek == 6)
                {

                    ++weekends;
                }
                else
                {
                    ++workDays;
                }

                startDate = startDate.AddDays(1);
            }
            return workDays;

        }
    }
}
