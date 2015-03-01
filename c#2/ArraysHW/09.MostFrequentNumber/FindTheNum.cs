//Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)

using System;

class FindTheNum
{
    static void Main()
    {
        int[] array = EnterArray();

        int mostFrequentNum = array[0];
        int mostFrequentNumCounter = 1;
        FindNum(array, ref mostFrequentNum, ref mostFrequentNumCounter);
        Console.WriteLine("The most frequent number is {0}({1} times).", mostFrequentNum, mostFrequentNumCounter);
    }

    private static void FindNum(int[] array, ref int mostFrequentNum, ref int mostFrequentNumCounter)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int currentNumCounter = 1;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    currentNumCounter++;
                }
            }
            if (currentNumCounter > mostFrequentNumCounter)
            {
                mostFrequentNumCounter = currentNumCounter;
                mostFrequentNum = array[i];
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