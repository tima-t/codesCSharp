using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DataDifference
{
    class DataDifference
    {
        static void Main()
        {
            string format = "d.M.yyyy";
           CultureInfo provider = CultureInfo.InvariantCulture;
            Console.Write("Enter the first date: ");
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), format ,provider);
            Console.Write("Enter the second date: ");
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), format, provider);
            if (firstDate>secondDate)
            {

                Console.WriteLine("wrong input ");
            }
            else
            {
                Console.WriteLine("the difference between two dates is  "+ (secondDate-firstDate).TotalDays);
            }

        }
    }
}
