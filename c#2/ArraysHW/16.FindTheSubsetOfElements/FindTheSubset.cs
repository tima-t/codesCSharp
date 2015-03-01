//We are given an array of integers and a number S. Write a program to find 
//if there exists a subset of the elements of the array that has a sum S.
using System;

class FindTheSubset
{
    static void Main()
    {
        int[] array = EnterArray();

        int S = EnterS();

        int combinationCode = new int();
        bool isFound = false;
        FindSubset(array, S, ref combinationCode, ref isFound);
        PrintResult(array, combinationCode, isFound);
    }

    private static void PrintResult(int[] array, int combinationCode, bool isFound)
    {
        if (isFound)
        {
            bool isFirstOutput = true;
            Console.Write("Yes, ");
            for (int i = 0; i < array.Length; i++)
            {
                int mask = 1 << i; //001
                int result = (combinationCode & mask) >> i;
                if (result == 1)
                {
                    if (!isFirstOutput)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        isFirstOutput = false;
                    }
                    Console.Write("{0}", array[i]);
                }
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    private static void FindSubset(int[] array, int S, ref int combinationCode, ref bool isFound)
    {
        for (int i = 1; i < Math.Pow(2, array.Length); i++)
        {//001
            int tempSum = 0;
            for (int j = 0; j < array.Length; j++)
            {
                int mask = 1 << j; //001
                int result = (i & mask) >> j;
                if (result == 1)
                {
                    tempSum += array[j];
                }
            }
            if (tempSum == S)
            {
                combinationCode = i;
                isFound = true;
                break;
            }
        }
    }

    private static int EnterS()
    {
        Console.Write("Enter S: ");
        int S = int.Parse(Console.ReadLine()); //8
        return S;
    }

    private static int[] EnterArray()
    {
        Console.Write("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());//3

        int[] array = new int[length]; //1 5 7
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter value for array[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }
}