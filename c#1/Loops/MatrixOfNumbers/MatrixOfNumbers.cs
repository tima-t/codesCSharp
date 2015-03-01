/*Problem 9. Matrix of Numbers

    Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.

 
 */

using System;


    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("write n\nn= ");
            int n = int.Parse(Console.ReadLine());
            int start = 1;
            int end = n;

            if (n < 0 || n > 20)
            {
                Console.WriteLine("wrong input ");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = start; j <= end; j++)
                    {
                        Console.Write("{0} ",j);
                    }
                    start++;
                    end++;
                    Console.WriteLine();


                }
            }
            Console.ReadLine();

        }
    }

