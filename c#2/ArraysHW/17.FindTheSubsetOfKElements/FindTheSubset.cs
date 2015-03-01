//Write a program that reads three integer numbers N, K and S and an 
//array of N elements from the console. Find in the array a subset of
//K elements that have sum S or indicate about its absence.
using System;

class FindTheSubset
{
    static void Main()
    {
        int N = EnterN();
        int S = EnterS();

        int K = EnterK();
        int[] array = EnterArray(N);

        int combinationCode = new int();
        bool isFound = false;
        FindSubset(S, K, array, ref combinationCode, ref isFound);
        PrintResult(array, combinationCode, isFound);
    }

    private static void PrintResult(int[] array, int combinationCode, bool isFound)
    {
        if (isFound)
        {
            Console.Write("Yes, ");
            for (int i = 0; i < array.Length; i++)
            {
                int mask = 1 << i;
                int result = (combinationCode & mask) >> i;
                if (result == 1)
                {
                    Console.Write("{0} ", array[i]);
                }
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    private static void FindSubset(int S, int K, int[] array, ref int combinationCode, ref bool isFound)
    {
        for (int i = 1; i < Math.Pow(2, array.Length); i++)
        {
            int tempSum = 0;
            int bitCounter = 0;
            for (int j = 0; j < array.Length; j++)
            {
                int mask = 1 << j;
                int result = (i & mask) >> j;
                if (result == 1)
                {
                    bitCounter++;
                    tempSum += array[j];
                }
            }
            if (tempSum == S && bitCounter == K)
            {
                combinationCode = i;
                isFound = true;
                break;
            }
        }
    }

    private static int[] EnterArray(int N)
    {
        int[] array = new int[N];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter value for array[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    private static int EnterK()
    {
        Console.Write("Enter K: ");
        int K = int.Parse(Console.ReadLine());
        return K;
    }

    private static int EnterS()
    {

        Console.Write("Enter S: ");
        int S = int.Parse(Console.ReadLine());
        return S;
    }

    private static int EnterN()
    {
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        return N;
    }
}