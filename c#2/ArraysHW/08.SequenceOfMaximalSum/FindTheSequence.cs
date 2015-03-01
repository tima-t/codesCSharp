//Write a program that finds the sequence of maximal sum in given array. Example:
//	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
//Can you do it with only one loop (with single scan through the elements of the array)?
using System;

class FindTheSequence
{
    static void Main()
    {
        int[] array = EnterArray();
        int startIndex = 0, endIndex = 0;
        FindSequence(array, ref startIndex, ref endIndex);
        PrintSequence(array, startIndex, endIndex);
    }

    private static void PrintSequence(int[] array, int startIndex, int endIndex)
    {
        Console.WriteLine("The sequence of maximal sum in the array:");
        for (int i = startIndex; i < endIndex + 1; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    private static void FindSequence(int[] array, ref int startIndex, ref int endIndex)
    {
        int tempStartIndex = 0;
        int currentSum = array[0], maxSum = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            currentSum += array[i];
            if (currentSum < array[i])
            {
                currentSum = array[i];
                tempStartIndex = i;
            }
            if (currentSum > maxSum)
            {
                startIndex = tempStartIndex;
                endIndex = i;
                maxSum = currentSum;
            }
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