using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        static void Main()
        {
            Console.WriteLine("write some text : ");
            string text = Console.ReadLine();
            char [] separators= {'.','?','-','!',' ','@'};
            string[] parts = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string reversed;
            char[] temp;
            bool anyPalidromes = false;
            foreach (var part  in parts)
            {
                temp = part.ToCharArray();
                Array.Reverse(temp);
                reversed = string.Join("", temp);
                if (part==reversed)
                {
                    Console.WriteLine(" {0}  is palindrome ",part);
                    anyPalidromes = true;
                }
            }
            if (!anyPalidromes)
            {
                Console.WriteLine("There arent any palindromes");
            }

        }
    }
}
