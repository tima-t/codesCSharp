//Sorting an array means to arrange its elements in increasing order.
//Write a program to sort an array. Use the "selection sort" algorithm: 
//Find the smallest element, move it at the first position, find the 
//smallest from the rest, move it at the second position, etc.

using System;

class Sort
{
    static void Main()
    {
        int[] array = EnterArray();
        SelectSort(array);
        PrintArray(array);
    }

    private static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.WriteLine(num);
        }
    }

    private static void SelectSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int smallestNumIndex = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[smallestNumIndex])
                {
                    smallestNumIndex = j;
                }
            }
            int swap = array[smallestNumIndex];
            array[smallestNumIndex] = array[i];
            array[i] = swap;
        }
    }

    private static int[] EnterArray()
    {
        Console.Write("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());

        int[] array = new int[length];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter value for array[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }
}