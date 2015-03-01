//Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
using System;
using System.Collections.Generic;

class QSort
{
    static void Main()
    {
        List<int> inputList = EnterArray();
        List<int> sortedList = QuickSort(inputList);
        PrintArray(sortedList);
    }

    private static void PrintArray(List<int> sortedList)
    {
        Console.WriteLine("Sorted array: ");
        foreach (int num in sortedList)
        {
            Console.WriteLine(num);
        }
    }

    private static List<int> EnterArray()
    {
        Console.Write("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());

        List<int> inputList = new List<int>();
        for (int i = 0; i < length; i++)
        {
            Console.Write("Enter value for intList[{0}]: ", i);
            inputList.Add(int.Parse(Console.ReadLine()));
        }
        return inputList;
    }

    static List<int> QuickSort(List<int> unsortedList)
    {
        if (unsortedList.Count <= 1)
        {
            return unsortedList;
        }
        int pivotIndex = unsortedList.Count / 2;
        int pivotValue = unsortedList[pivotIndex];
        unsortedList.RemoveAt(pivotIndex);
        List<int> lesser = new List<int>();
        List<int> greater = new List<int>();
        foreach (int element in unsortedList)
        {
            if (element <= pivotValue)
            {
                lesser.Add(element);
            }
            else
            {
                greater.Add(element);
            }
        }
        List<int> sortedList = new List<int>();
        sortedList.AddRange(QuickSort(lesser));
        sortedList.Add(pivotValue);
        sortedList.AddRange(QuickSort(greater));
        return sortedList;

    }
}