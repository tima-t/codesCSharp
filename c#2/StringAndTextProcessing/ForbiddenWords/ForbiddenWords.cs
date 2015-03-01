using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main()
        {
            Console.WriteLine("write a list of forbiden words, separated by coma or white space");
            string[] seps = { ".", ",", " " };
            string[] forbWords = Console.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("write your text: ");
            string text = Console.ReadLine();
            string result="";
            string aestericks;
            
            //Example text
           // string text = " Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            for (int i = 0; i < forbWords.Length; i++)
            {
                aestericks = new string('*', forbWords[i].Length);
                result = text.Replace(forbWords[i], aestericks);
                text = result;

            }
           
            Console.WriteLine(result);
        }
    }
}
