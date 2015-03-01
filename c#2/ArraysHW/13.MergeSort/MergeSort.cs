//Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).
using System;
using System.Collections.Generic;

class MergeSort
{
    static void Main()
    {
        List<int> inputList = EnterArray();
        List<int> sortedList = Merge(inputList);
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
    static List<int> Merge(List<int> inputList)
    {
        if (inputList.Count <= 1)
        {
            return inputList;
        }
        List<int> left = new List<int>();
        List<int> right = new List<int>();
        int middle = inputList.Count / 2;
        for (int i = 0; i < middle; i++)
        {
            left.Add(inputList[i]);
        }
        for (int i = middle; i < inputList.Count; i++)
        {
            right.Add(inputList[i]);
        }
        left = Merge(left);
        right = Merge(right);
        return Merge(left, right);
    }

    static List<int> Merge(List<int> left, List<int> right)
    {
        List<int> result = new List<int>();
        while (left.Count > 0 || right.Count > 0)
        {
            if (left.Count > 0 && right.Count > 0)
            {
                if (left[0] < right[0])
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }
            else if (left.Count > 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }
            else
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }
        }
        return result;
    }
}