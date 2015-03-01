using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace DateInBulgaria
{
    class DateInBulgaria
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            string format = "d.M.yyyy H:m:s";
            CultureInfo provider = CultureInfo.GetCultureInfo("BG-bg");
            //17.2.2015 15:23:23
            Console.Write("Enter the date (dd.MM.yyyy HH:mm:ss): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), format, provider);
            date = date.AddHours(6.5);
            Console.WriteLine(date.ToString("dd.MM.yyyy HH:mm:ss dddd"), provider);
        }
    }
}
