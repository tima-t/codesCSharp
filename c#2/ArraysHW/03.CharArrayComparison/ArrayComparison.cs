//Write a program that compares two char arrays lexicographically (letter by letter).
using System;

class ArrayComparison
{
    static void Main()
    {
        char[] firstArray = EnterArray("first");

        char[] secondArray = EnterArray("second");

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

    private static bool ArrayCompare(char[] firstArray, char[] secondArray)
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

    private static char[] EnterArray(string index)
    {
        Console.Write("Enter the length of the {0} array: ", index);
        int length = int.Parse(Console.ReadLine());
        char[] array = new char[length];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter value for {0}Array[{1}] ", index, i);
            array[i] = char.Parse(Console.ReadLine());
        }
        return array;
    }
}