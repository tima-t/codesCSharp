using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSentences
{
    class ReverceSenteces
    {
        static void Main()
        {
            Console.WriteLine("write your sentence");
            string sentence = Console.ReadLine();
            Console.WriteLine(Reverse(sentence));

        }

        public static string Reverse(string sentence)
        {
            StringBuilder result = new StringBuilder();
            char [] sep = { ' ' };

            string[] words = (sentence.Substring(0,sentence.Length-1)).Split(sep, StringSplitOptions.RemoveEmptyEntries);
            for (int i = words.Length-1; i >=0; i--)
            {
                result.Append(words[i]);
                if (i!=0)
                {
                     result.Append(" ");
                }
                
                     
                
            }
            result.Append(sentence[sentence.Length - 1]);
            return result.ToString();

            
        }
    }
}
