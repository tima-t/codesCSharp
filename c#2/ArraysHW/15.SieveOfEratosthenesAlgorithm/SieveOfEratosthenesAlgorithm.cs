//Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
using System;
using System.Collections.Generic;

class SieveOfEratosthenesAlgorithm
{
    static void Main()
    {
        int N = 10000000;
        List<bool> isPrime = Initialize(N);
        FindPrimeNumbers(N, isPrime);
        PrintPrimeNumbers(N, isPrime);
    }

    private static void PrintPrimeNumbers(int N, List<bool> isPrime)
    {
        for (int i = 0; i < N; i++)
        {
            if (isPrime[i])
            {
                Console.WriteLine(i);
            }
        }
    }

    private static void FindPrimeNumbers(int N, List<bool> isPrime)
    {
        for (int i = 2; i <= Math.Sqrt(N); i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j < N; j = j + i)
                {
                    isPrime[j] = false;
                }
            }
        }
    }

    private static List<bool> Initialize(int N)
    {
        List<bool> isPrime = new List<bool>();
        for (int i = 0; i < N; i++)
        {
            isPrime.Add(true);
        }
        return isPrime;
    }
}