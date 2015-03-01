/*Problem 1. Sum of 3 Numbers

    Write a program that reads 3 real numbers from the console and prints their sum.

 */


using System;


    class SumOf3Numbers
    {
        static void Main()
        {
            Console.Write("write your first real number:  ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("write your second real number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("write your third real number:  ");
            double thirdNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("The sum is {0}",firstNumber+secondNumber+thirdNumber);
            Console.ReadLine(); // pause

        }
    }

