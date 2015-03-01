//Problem 1. Allocate array
//
//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.
using System;
class Program
{
    static void Main()
    {

        int n = 20;

        int multiplier = 5;
        int[] integersArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            integersArray[i] = i * multiplier;
        }

        Console.WriteLine(String.Join(", ", integersArray));
    }
}

