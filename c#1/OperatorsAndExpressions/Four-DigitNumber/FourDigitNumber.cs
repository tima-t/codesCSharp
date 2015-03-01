/*
    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
        Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
        Prints on the console the number in reversed order: dcba (in our example 1102).
        Puts the last digit in the first position: dabc (in our example 1201).
        Exchanges the second and the third digits: acbd (in our example 2101).

The number has always exactly 4 digits and cannot start with 0.
 */
using System;



    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("write your 4-digit number ");
            uint number = uint.Parse(Console.ReadLine());
            uint a = number / 1000;
            if (a == 0 || number<1000 || number>9999)
            {
                Console.WriteLine("wrong input , the numebr shoud be four-digit and cant start with 0 ");
            }
            else
            {
                uint b = (number % 1000) / 100;
                uint c = (number % 100) / 10;
                uint d = (number % 10);
                Console.WriteLine("The sum of the numbers is {0}", a + b + c + d);
                Console.WriteLine("Number in reversed order is {0}", d * 1000 + c * 100 + b * 10 + a);
                Console.WriteLine("Puts the last digit in first position {0}", d * 1000 + a * 100 + b * 10 + c);
                Console.WriteLine("Exchange the second and third digit {0}", a * 1000 + c * 100 + b * 10 + d);
            }
            Console.Read();//pause
        }

    }

