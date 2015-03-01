using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCount
{
    class LettersCount
    {
        static void Main()
        {
            Console.WriteLine("write your text ");
            string text = Console.ReadLine();
            string textToLower= text.ToLower();
            Dictionary<char,int> letters = new Dictionary<char,int>();
        
            for (int i = 'a'; i <='z'; i++)
            {
                letters.Add((char)i, 0);
                
            }

            foreach (var symbol in textToLower)
            {
                for (int i = 0; i < letters.Count; i++)
                {
                    if (symbol == letters.ElementAt(i).Key)
                    {
                         letters[letters.ElementAt(i).Key] += 1;
                    }
                   
                }
                
            }

            foreach (var letter in letters)
            {
                Console.WriteLine((letter.Key + " = " + letter.Value));
            }

        }
    }
}
