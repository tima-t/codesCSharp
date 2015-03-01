//Write a program that finds the maximal sequence of equal elements in an array.
//		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.
using System;

class FindTheSequence
{
    static void Main()
    {
        int[] array = EnterArray();

        int sequenceEndIndex;
        int sequenceLength;

        FindSequence(array, out sequenceEndIndex, out sequenceLength);

        PrintSequence(array, sequenceEndIndex, sequenceLength);
    }

    private static void FindSequence(int[] array, out int sequenceEndIndex, out int sequenceLength)
    {
        sequenceEndIndex = 0;
        sequenceLength = 0;
        int currentSequenceLength = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i < array.Length - 1 && array[i] == array[i + 1])
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

    private static void PrintSequence(int[] array, int sequenceEndIndex, int sequenceLength)
    {
        for (int i = (sequenceEndIndex - sequenceLength); i <= sequenceEndIndex; i++)
        {
            Console.WriteLine(array[i]);
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