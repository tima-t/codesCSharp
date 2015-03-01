/*
 * Problem 1. Numbers from 1 to N

    Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.

 */
using System;

    class NumbersFrom1ToN
    {
        static void Main()
        {
            Console.Write("Write the count of secuence ( positive number) \nn= ");
            int n = int.Parse(Console.ReadLine());
            int temp;
            int max=int.MinValue;
            int min=int.MaxValue;
            float sum = 0;
        
            if (n < 1)
            {
                Console.WriteLine("wrong input");

            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Write you positive number \nn= ");
                    temp = int.Parse(Console.ReadLine());
                    if (temp > max)
                    {
                        max = temp;
                    }
                    if (temp < min)
                    {
                        min = temp;
                    }
                    sum += temp;

                   
                }
                Console.WriteLine("the max number is {0,-30}",max);
                Console.WriteLine("the min number is {0,-30}",min);
                Console.WriteLine("the sum is {0,-30}",sum);
                Console.WriteLine(  "the average is {0,-30:F2}",(sum/n)) ;

            }
            Console.ReadLine();//pause
        }
    }

