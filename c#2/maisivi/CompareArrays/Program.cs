//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and compares them element by element.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose a lenght for both the arrays");
        int n = int.Parse(Console.ReadLine());
        int[] ArrayA = new int[n];
        int[] ArrayB = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Array A[{0}] = ", i);
            ArrayA[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write("Array B[{0}] = ", i);
            ArrayB[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            bool isEqual = ArrayA[i] == ArrayB[i];
            if (isEqual == true)
            {
                Console.WriteLine("Numbers {0} and {1} are equal", ArrayA[i],ArrayB[i]);
            }
            if (isEqual == false)
            {
                Console.WriteLine("Numbers {0} and {1} are not equal", ArrayA[i], ArrayB[i]);
            }
       }
    }
}