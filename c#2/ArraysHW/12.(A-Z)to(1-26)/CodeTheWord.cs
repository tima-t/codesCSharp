//Write a program that creates an array containing all letters from
//the alphabet (A-Z). Read a word from the console and print the index 
//of each of its letters in the array.
using System;

class CodeTheWord
{
    static void Main()
    {
        char[] englishAlphabet = InitializeEnglishAlphabet();

        string inputWord = EnterWord();

        Coding(englishAlphabet, inputWord);
    }

    private static void Coding(char[] englishAlphabet, string inputWord)
    {
        Console.Write("The index of each letters: ");
        foreach (char letter in inputWord)
        {
            int low = 0;
            int high = englishAlphabet.Length - 1;

            while (low <= high)
            {
                int middle = (low + high) / 2;
                if (englishAlphabet[middle] > letter)
                {
                    high = middle - 1;
                }
                else if (englishAlphabet[middle] < letter)
                {
                    low = middle + 1;
                }
                else
                {
                    Console.Write("{0} ", middle);
                    break;
                }
            }
        }
    }

    private static string EnterWord()
    {
        Console.Write("Enter the word: ");
        string inputWord = Console.ReadLine();
        return inputWord;
    }

    private static char[] InitializeEnglishAlphabet()
    {
        char[] englishAlphabet = new char[26];
        for (int i = 0; i < englishAlphabet.Length; i++)
        {
            englishAlphabet[i] = (char)('a' + i);
        }
        return englishAlphabet;
    }
}