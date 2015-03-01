using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsCount
{
    class WordsCount
    {
        static void Main()
        { Console.WriteLine("write your text ");
            string text = Console.ReadLine();
            string textToLower= text.ToLower();
            char [] seps = {' ',',','!','?'};
            string[] words = textToLower.Split(seps, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string,int> wordsd = new Dictionary<string,int>();
        
            for (int i = 0; i <words.Length; i++)
            {
                if (wordsd.ContainsKey(words[i]))
                {
                    continue;
                }
                wordsd.Add(words[i], 0);
                
                
            }

            foreach (var word in words)
            {
                for (int i = 0; i < wordsd.Count; i++)
                {
                    if (word == wordsd.ElementAt(i).Key)
                    {
                         wordsd[wordsd.ElementAt(i).Key] += 1;
                    }
                   
                }
                
            }

            foreach (var wor in wordsd)
            {
                Console.WriteLine((wor.Key + " = " + wor.Value));
            }

        
        }
    }
}
