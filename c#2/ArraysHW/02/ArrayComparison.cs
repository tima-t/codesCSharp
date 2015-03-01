//Write a program that reads two arrays from the console and compares them element by element.
using System;

class ArrayComparison
{
    static void Main()
    {
        int[] firstArray = EnterArray("first");

        int[] secondArray = EnterArray("second");

        bool areEqual = ArrayCompare(firstArray, secondArray);

        if (areEqual)
        {
            Console.WriteLine("Two arrays are equal!");
        }
        else
        {
            Console.WriteLine("Two arrays are not equal!");
        }
    }

    private static bool ArrayCompare(int[] firstArray, int[] secondArray)
    {
        bool areEqual = true;
        if (firstArray.Length == secondArray.Length)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                    break;
                }
            }
        }
        else
        {
            areEqual = false;
        }
        return areEqual;
    }

    private static int[] EnterArray(string index)
    {
        Console.Write("Enter the length of the {0} array: ", index);
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter value for {0}Array[{1}]: ", index, i);
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }
}