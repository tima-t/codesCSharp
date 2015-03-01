/*Problem 7. Sum of 5 Numbers

    Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

 */

using System;




    class SumOf5Numbers
    {
        static void Main()
        {
            Console.WriteLine("print 5 numbers on a single line separated by space : ");
            string numbers = Console.ReadLine();
            string[] parts = numbers.Split(new char[] { ' ' });
            double sum = double.Parse(parts[0]) + double.Parse(parts[1]) + double.Parse(parts[2]) + double.Parse(parts[3]) + double.Parse(parts[4]);
            Console.WriteLine("the sum of the numbers is {0}",sum);
            Console.ReadLine();//pause

        }
    }

