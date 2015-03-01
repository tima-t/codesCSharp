/*Problem 5. Third Digit is 7?

    Write an expression that checks for given integer if its third digit from right-to-left is 7.


*/
using System;


namespace ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main()
        {
            bool is3rdDigit7;
            Console.WriteLine("write your number :");
            int number=int.Parse( Console.ReadLine());
            is3rdDigit7 = (((number % 1000) / 100) == 7);
            Console.WriteLine("your number {0} third digit from right to left  is 7: {1}",number,is3rdDigit7);
            Console.ReadKey(); // pause
        }
    }
}
