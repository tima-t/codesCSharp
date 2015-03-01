//Write a program that reads two integer numbers N and K and an array 
//of N elements from the console. Find in the array those K elements that have maximal sum.
using System;

class FindTheSum
{
    static void Main()
    {
        int N = new int();
        int K = new int();
        EnterNandK(out N, out K);

        int[] array = EnterArray(N);

        SortTheArray(array);
        //Array.Sort(array);
        PrintPartOfArray(K, array);
    }

    private static void PrintPartOfArray(int K, int[] array)
    {
        Console.WriteLine("K elements from the array that have maximal sum:");
        for (int i = array.Length - 1; i >= array.Length - K; i--)
        {
            Console.WriteLine(array[i]);
        }
    }

    private static void SortTheArray(int[] array)
    {
        bool isSorted = new bool();
        do
        {
            isSorted = true;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int swap = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = swap;
                    isSorted = false;
                }
            }
        } while (!isSorted);
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

    private static void EnterNandK(out int N, out int K)
    {
        do
        {
            Console.Write("Enter N: ");
            N = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            K = int.Parse(Console.ReadLine());
            if (K > N)
            {
                Console.WriteLine("K can't be bigger then N");
            }
        } while (K > N);
    }
}