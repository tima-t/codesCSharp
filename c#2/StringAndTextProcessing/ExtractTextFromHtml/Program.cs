using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractTextFromHtml
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("write your text: ");
            string text = Console.ReadLine();
            //to check 
           //  string text="<html><head><title>News</title></head><body><p><a href=http:academy.telerik.com>TelerikAcademy</a>aims to provide free real-world practicaltraining for young people who want to turn intoskilful .NET software engineers.</p></body></html>";
            StringBuilder textWithoutTags = new StringBuilder(text);
            int indexOpen=0;
            int indexClose = 0;
            if (text.IndexOf("<title>")>0 && text.IndexOf("</title>")>0)
            {
                Console.WriteLine("the title is {0}",text.Substring(text.IndexOf("<title>")+7,text.IndexOf("</title>")-7-text.IndexOf("<title>")));
            }
            while (true)
            {
                indexOpen = text.IndexOf('<',indexOpen);
                indexClose = text.IndexOf('>',indexClose);
               
                if (indexOpen < 0 || indexClose < 0)
                {
                    break;

                }
                if (indexOpen>=0&& indexClose>=indexOpen)
                {
                    textWithoutTags.Remove(indexOpen, indexClose+1 - indexOpen);
                    textWithoutTags.Insert(indexOpen, new string(' ', indexClose + 1 - indexOpen));
                }
                
               
                indexOpen++;
                indexClose++;

            }
            string temp=textWithoutTags.ToString();
            char[] seps={' '};
            string[] final = temp.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join(" ",final));


        }
    }
}
