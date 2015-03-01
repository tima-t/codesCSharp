//Write a program that finds the maximal increasing sequence in an array. 
//Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.
using System;

class FindTheSequence
{
    static void Main()
    {
        int[] array = EnterArray();

        int sequenceEndIndex = 0;
        int sequenceLength = 0;

        FindSequence(array, ref sequenceEndIndex, ref sequenceLength);

        PrintSequence(array, sequenceEndIndex, sequenceLength);
    }

    private static void PrintSequence(int[] array, int sequenceEndIndex, int sequenceLength)
    {
        for (int i = (sequenceEndIndex - sequenceLength); i <= sequenceEndIndex; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    private static void FindSequence(int[] array, ref int sequenceEndIndex, ref int sequenceLength)
    {
        int currentSequenceLength = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i < array.Length - 1 && array[i] + 1 == array[i + 1])
            {
                currentSequenceLength++;
            }
            else
            {
                if (currentSequenceLength > sequenceLength)
                {
                    sequenceLength = currentSequenceLength;
                    sequenceEndIndex = i;
                }
                currentSequenceLength = 0;
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