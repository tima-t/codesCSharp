using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTags
{
    class ReplaceTags
    {
        static void Main()
        {
            Console.WriteLine("write your text in html format");
             string text = Console.ReadLine();
             string replace = text.Replace("<a href=\"", "[URL=");
             string replace2 = replace.Replace("\">", "]");
             string fixedText = replace2.Replace("</a> ", "[/URL]");
             Console.WriteLine(fixedText);

        }
    }
}
