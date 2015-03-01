using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapY
{
    class LeapY
    {
        static void Main()
        {
            Console.Write("write the year that we will check  : ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("your year is leap : ");
            Console.WriteLine(DateTime.IsLeapYear(year));
        }
    }
}
