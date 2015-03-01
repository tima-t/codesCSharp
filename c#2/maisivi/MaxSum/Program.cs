//Problem 8. Maximal sum
//
//Write a program that finds the sequence of maximal sum in given array.
using System;
class Program
    {
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        int maxSum = int.MinValue;
        string sequence = "";
        string sequenceWithMaxSum = "";
        
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            sequence = sequence + " " + array[i];
            if (sum > maxSum)
            {
                maxSum = sum;
                sequenceWithMaxSum = sequence;
            }
            if (sum < 0)
            {
                sum = 0;
                sequence = "";
            }
        }
        Console.WriteLine("The sequence of maximal sum is {{{0} }} with sum = {1}", sequenceWithMaxSum, maxSum);
    }
    }

