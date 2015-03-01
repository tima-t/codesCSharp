//Write a program that reads two numbers N and K and generates all the 
//combinations of K distinct elements from the set [1..N]. Example:
//	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
using System;
using System.Collections.Generic;

class Combinations
{
    static void Main()
    {
        int N = new int();
        int K = new int();
        EnterNandK(ref N, ref K);
        int[] array = InitializeArray(N);
        PrintAllCompinations(K, array);
    }

    private static void PrintAllCompinations(int K, int[] array)
    {
        List<int> currentCombination = new List<int>();
        for (int j = 0; j < Math.Pow(2, array.Length); j++)
        {
            int bitCounter = 0;
            for (int k = 0; k < array.Length; k++)
            {
                int mask = 1 << k;
                int result = (j & mask) >> k;
                if (result == 1)
                {
                    currentCombination.Add(array[k]);
                    bitCounter++;
                }
            }
            if (bitCounter == K)
            {
                foreach (int num in currentCombination)
                {
                    Console.Write("{0} ", num);
                }
                Console.WriteLine();
            }
            currentCombination.Clear();
        }
    }

    private static int[] InitializeArray(int N)
    {
        int[] array = new int[N];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }
        return array;
    }

    private static void EnterNandK(ref int N, ref int K)
    {
        do
        {
            Console.Write("Enter N: ");
            N = int.Parse(Console.ReadLine());

            Console.Write("Enter K: ");
            K = int.Parse(Console.ReadLine());

            if (N < K)
            {
                Console.WriteLine("N can't be less then K");
            }
        } while (N < K);
    }
}