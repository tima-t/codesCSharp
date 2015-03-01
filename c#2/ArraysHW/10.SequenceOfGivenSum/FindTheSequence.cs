//Write a program that finds in given array of integers a sequence of given sum S (if present). Example:	 
//{4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}
using System;

class FindTheSequence
{
    static void Main()
    {
        int[] array = EnterArray();

        int S = EnterS();
        
        int startIndex = 0, endIndex = 0;
        bool isFound = false;
        FindSequence(array, S, ref startIndex, ref endIndex, ref isFound);

        PrintSequence(array, startIndex, endIndex, isFound);
    }

    private static void PrintSequence(int[] array, int startIndex, int endIndex, bool isFound)
    {
        if (isFound)
        {
            Console.WriteLine("The sequence of given sum s is: ");
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        else
        {
            Console.WriteLine("A sequence with the given sum does not exist.");
        }
    }

    private static void FindSequence(int[] array, int S, ref int startIndex, ref int endIndex, ref bool isFound)
    {
        int currentSum = 0;

        for (int i = 0; i < array.Length; i++)//{4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}
        {
            currentSum += array[i];
            if (currentSum == S)
            {
                endIndex = i;
                isFound = true;
                break;
            }
            else if (currentSum > S)
            {
                if (array[i] == S)
                {
                    startIndex = i;
                    endIndex = i;
                    isFound = true;
                    break;
                }
                if (array[i] > S)
                {
                    startIndex = i + 1;
                    currentSum = 0;
                }
                if (array[i] < S)
                {
                    startIndex = i;
                    currentSum = array[i];
                }
            }
        }
    }

    private static int EnterS()
    {
        Console.Write("Enter S: ");
        int S = int.Parse(Console.ReadLine());
        return S;
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