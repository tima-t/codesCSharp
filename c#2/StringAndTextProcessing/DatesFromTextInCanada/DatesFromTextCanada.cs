using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;


namespace DatesFromTextInCanada
{
    class DatesFromTextCanada
    {

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
            Console.WriteLine("write your dates");
            string text = Console.ReadLine();
            string format = "d.M.yyyy";
            CultureInfo provider = Thread.CurrentThread.CurrentCulture;
            foreach (var match in Regex.Matches(text, @"[\d]{1,2}.[\d]{1,2}.[\d]{4}"))
            {

                DateTime check = DateTime.ParseExact(match.ToString(), format, provider);
                Console.WriteLine(check.ToShortDateString());

            }
        }
    }
}
