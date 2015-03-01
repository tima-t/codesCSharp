//Problem 3. Compare char arrays
//
//Write a program that compares two char arrays lexicographically (letter by letter).
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first char array as string");
        char[] firstArray = Console.ReadLine().ToCharArray();
        Console.WriteLine("Enter second char array as string");
        char[] secondArray = Console.ReadLine().ToCharArray();
        int loopLenght = Math.Min(firstArray.Length, secondArray.Length);
        int smallerArray = 0;
        for (int i = 0; i < loopLenght; i++)
        {
            if (firstArray[i] <secondArray[i])
            {
                smallerArray = 1;
                break;
            }
            else if (firstArray[i] > secondArray[i])
            {
                smallerArray = 2;
                break;
            }
        }

        if (smallerArray == 1)
        {
            Console.WriteLine("The first array is earlier.");
        }
        else if (smallerArray == 2)
        {
            Console.WriteLine("The second array is earlier.");
        }
        else
        {
            if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine("The second array is earlier.");
            }
            else if (firstArray.Length < secondArray.Length)
            {
                Console.WriteLine("The first array is earlier.");
            }
            else
            {
                Console.WriteLine("The two arrays are the same.");
            }
        }

    }
}

