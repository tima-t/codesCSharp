//Write a program that allocates array of 20 integers 
//and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.
using System;

class ArrayOfInts
{
    static void Main()
    {
        int arrayLength = 20;
        int[] arrayOfInts = new int[arrayLength];
        for (int i = 0; i < arrayOfInts.Length; i++)
        {
            arrayOfInts[i] = i * 5;
            Console.WriteLine(arrayOfInts[i]);
        }
    }
}