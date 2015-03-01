//Problem 12. Index of letters﻿
// Write a program that creates an array containing all letters from the alphabet (A-Z). 
// Read a word from the console and print the index of each of its letters in the array.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter word: ");
        
        string word = Console.ReadLine().ToUpper();
        int[] indexLetter = new int[27];
        for (int i = 1; i < indexLetter.Length; i++)
        {
            indexLetter[i] = ('A' - 1) + i;
        }
                   
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < indexLetter.Length; j++)
            {
                if (word[i] == indexLetter[j])
                {
                    Console.WriteLine("Letter {0} has index: {1} (starting from 1)", word[i], j);
                }
            }
        }
    }
}