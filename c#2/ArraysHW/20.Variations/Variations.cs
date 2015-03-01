//Write a program that reads two numbers N and K and generates all the variations 
//of K elements from the set [1..N].
using System;

class GenerateVariations
{
    static void Main()
    {
        int N = EnterN();
        int K = EnterK();
        int[] array = new int[K];
        Variations(array, N, 0);
    }

    static void Variations(int[] array, int N, int index)
    {
        if (index == array.Length)
        {
            foreach (int num in array)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
        }
        else
        {
            for (int i = 1; i <= N; i++)
            {
                array[index] = i;
                Variations(array, N, index + 1);
            }
        }
    }

    private static int EnterK()
    {
        Console.Write("Enter K: ");
        int K = int.Parse(Console.ReadLine());
        return K;
    }

    private static int EnterN()
    {
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        return N;
    }
}