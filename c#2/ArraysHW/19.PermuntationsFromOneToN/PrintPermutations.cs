//Write a program that reads a number N and generates and prints all 
//the permutations of the numbers [1 … N]. Example:
//	n = 3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}
using System;
using System.Collections.Generic;

class PrintPermuntations
{
    static void Main()
    {
        int N = EnterN();

        int[] array = InitializeArray(N);

        PrintAllPermutations(N, array);
    }

    private static void PrintAllPermutations(int N, int[] array)
    {
        int permutations = CalculatePermutations(array);
        PrintCurrentPermutation(array);
        for (int currentPerm = 1; currentPerm < permutations; currentPerm++)
        {
            GetNextPermutation(N, array);
            PrintCurrentPermutation(array);
        }
    }

    private static void GetNextPermutation(int N, int[] array)
    {//s rekursiq i baba znae :D
        int i;
        for (i = N - 1; array[i - 1] >= array[i] && (i - 1) >= 0; i--) ;
        int j;
        for (j = N; array[j - 1] <= array[i - 1] && (j - 1) >= 0; j--) ;
        Swap(array, i, j);
        for (i++, j = N; i < j; i++, j--)
        {
            Swap(array, i, j);
        }
    }

    private static int EnterN()
    {
        int N = new int();
        do
        {
            Console.Write("Enter N: ");
            N = int.Parse(Console.ReadLine());
            if (N <= 0)
            {
                Console.WriteLine("N must be bigger then 0.");
            }
        } while (N <= 0);
        return N;
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

    private static int CalculatePermutations(int[] array)
    {
        int permutations = 1;
        for (int i = 0; i < array.Length; i++)
        {
            permutations *= array[i];
        }
        return permutations;
    }

    private static void PrintCurrentPermutation(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();
    }

    private static void Swap(int[] array, int i, int j)
    {
        int swap = array[i - 1];
        array[i - 1] = array[j - 1];
        array[j - 1] = swap;
    }
}