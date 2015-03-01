/*Problem 9. Sum of n Numbers

    Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
*/

using System;

    class SumOfNnumbers
    {
        static void Main()
        {
            Console.Write("write unsigned n and then you will right n numbers and we will print the sum \n n= ");
            uint n = uint.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("write your number : ");
                double temp = double.Parse(Console.ReadLine());
                sum = sum + temp;

            }
            Console.WriteLine("the sum is {0}",sum);
            Console.ReadLine(); //pasue 

        }
    }

