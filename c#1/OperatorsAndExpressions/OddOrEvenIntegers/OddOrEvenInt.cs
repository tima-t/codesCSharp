/*
 * Problem 1. Odd or Even Integers

    Write an expression that checks if given integer is odd or even.

*/
using System;


namespace OddOrEvenIntegers
{
    class OddOrEvenInt
    {
        static void Main()
        {
            int var1;
            Console.WriteLine("write your number");
            var1 = int.Parse(Console.ReadLine());
            if (var1 % 2 == 0)// checks if the number is even
            {
                Console.WriteLine("your number : {0} is  even",var1); 

            }

            else
            {
                Console.WriteLine("your number: {0} is odd",var1);
            }
            Console.ReadKey(); // pause

        }
    }
}
