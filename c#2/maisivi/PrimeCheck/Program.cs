﻿//15. Write a program that finds all prime numbers in the range 
//    [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).


using System;

class Program
{
    static void Main()
    {
        long n = 10000000;
        bool[] e = new bool[n];
        for (int i = 2; i < n; i++)
        {
            e[i] = true;
        }
       
        for (int j = 2; j < n; j++)
        {
            if (e[j])
            {
                for (long p = 2; (p * j) < n; p++)
                {
                    e[p * j] = false;
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (e[i])
            {
                Console.WriteLine("{0} -> {1}", i, e[i]);
            }
        }
    }
}
