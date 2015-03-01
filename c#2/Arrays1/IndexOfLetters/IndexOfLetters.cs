/*Problem 12. Index of letters

Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.
 */


using System;


namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            char target;
            char[] array = new char[52];
            int count=0;
            for (int i = 'a'; i <= 'z'; i++)
            {
                array[count]=(char)i;
                count++;
            }
            for (int i = 'A'; i <= 'Z'; i++)
            {
                array[count] = (char)i;
                count++;
            }
            Console.Write("write your word: ");
            string word = Console.ReadLine();
            for(int i =0 ; i< word.Length;i++)
            {
                target = word[i];
                for(int j =0;j<52;j++)
                {
                    if (target == array[j])
                    {
                        Console.Write("{0} ",j);
                    }
                }
            }

            
        }
    }
}
