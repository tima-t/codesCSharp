using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            Console.WriteLine("write your string : " );
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            char lastChar = '\0';
        
            foreach (var letter in text)
            {
               
                if (letter != lastChar)
                {
                    
                   // result.Append(count);
                    //result.Append(lastChar); with coments write the count of letter infront of it 
                    result.Append(letter);
                   // count = 1;
                }
             /*   else
                {
                    count++;
                }
                   
              * */
                lastChar = letter;
            }
            Console.WriteLine(result);

        }
    }
}
