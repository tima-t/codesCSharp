using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_after_10_years
{
    class AgeAfterTenYears
    {
        public static int calculateAge(string birthyear, string birthmonth, string birthday)  // This is a method that calculate the current age 
        {
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;
            int currentDay = DateTime.Now.Day;
            int age = 0;
            if (int.Parse(birthmonth) > currentMonth)
            {
                age = currentYear - int.Parse(birthyear) - 1;

            }
            if (int.Parse(birthmonth) == currentMonth && (int.Parse(birthday) <= currentDay))
            {
                age = currentYear - int.Parse(birthyear);


            }
            else
            {
                age = currentYear - int.Parse(birthyear) - 1;
            }

            if (int.Parse(birthmonth) < currentMonth)
            {
                age = currentYear - int.Parse(birthyear);



            }

            return age;
        }
        static void Main(string[] args)
        {
        
            Console.WriteLine("Please enter your birthday in the format YY-MM-DD : ");

            string line = Console.ReadLine();
            string[] parts = line.Split(new char[] { '-' });
            int age = calculateAge(parts[0], parts[1], parts[2]);
            int currentYear = DateTime.Now.Year;
            Console.WriteLine("Now is {0} and you are {1}  years old ", DateTime.Now, age);
            Console.WriteLine(" After 10 years in  {0}  you will be {1} years old ", DateTime.Now.AddYears(10), (age + 10));
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
