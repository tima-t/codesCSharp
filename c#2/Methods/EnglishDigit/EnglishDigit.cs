using System;


namespace EnglishDigit
{
    class EnglishDigit
    {
        public static string EnglishDigit1(int number )
        {
            byte lastDigit = (byte)(number % 10);
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            for (int i = 0; i < digits.Length; i++)
            {
                if (lastDigit==i)
                {
                    return digits[i];
                    
                }

                
                
            }
            return "something get wrong";
        }

       
        static void Main()
        {
            Console.Write("write your number :  ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("the last digit of your number is {0}",EnglishDigit1(number));
        }
    }
}
