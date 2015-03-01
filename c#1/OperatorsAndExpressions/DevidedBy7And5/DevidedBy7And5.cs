/*
 Problem 3. Divide by 7 and 5

    Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

 */



using System;


namespace DevidedBy7And5
{
    class DevidedBy7And5
    {
        static void Main()
        {
            bool isDevideableBy7And5;
            Console.WriteLine("write your number and we will check if it is devideable by 7 and 5 at the same time ");
            int number =int.Parse( Console.ReadLine());
            isDevideableBy7And5 = (number % 7 == 0 && number % 5 == 0);
            Console.WriteLine("this statement is {0}",isDevideableBy7And5);
            Console.ReadLine();//pause
        }
    }
}
