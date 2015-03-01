//Problem 4. Maximal sequence
//
//Write a program that finds the maximal sequence of equal elements in an array.
using System;


class Program
{
    static void Main()
    {
        Console.Write("Enter a number N (size of array): ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        Console.WriteLine("\nEnter a {0} number(s) to array: ", n);
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("   {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int currentLength = 1, currentElement = numbers[0];

        int bestElement = 0; 
        int bestLength = 0;

        if (numbers.Length == 1)
        {
            bestElement = currentElement;
            bestLength = 1;
            return;
        }

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == currentElement)
            {
                currentLength++;
            }
            else
            {
                currentElement = numbers[i];
                currentLength = 1;
            }

            if (currentLength >= bestLength)
            {
                bestLength = currentLength;
                bestElement = currentElement;
            }
        }
        {
            Console.Write("-> Best sequence: ");
            for (int i = 0; i < bestLength; i++) 
            Console.Write(bestElement + " ");
            Console.WriteLine("\n");
        }
    }
}
