/*Problem 3. Min, Max, Sum and Average of N Numbers

    Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
    The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
    The output is like in the examples below.
*/


using System;


class MinMaxSumAverageOfNnumbers
{
    static void Main()
    {
        Console.WriteLine("write  the count your number ");
        int n = int.Parse(Console.ReadLine());
       int currentNumber;
        double sum = 0;
     
        int min = int.MaxValue;
        int max = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("write   your number ");
            currentNumber = int.Parse(Console.ReadLine());

            sum += currentNumber;
            if (min > currentNumber)
            {
                min = currentNumber;
            }
            if (max < currentNumber)
            {
                max = currentNumber;
            }

        }
        Console.WriteLine("min = {0}", min );
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("average = {0:0.00}", sum/n);
        Console.ReadLine();//pause
    }
  
}

