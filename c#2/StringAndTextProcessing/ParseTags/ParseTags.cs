using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTags
{
    class ParseTags
    {
        static void Main()
        {
            string text = " We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.<upcase> it works properly maybe</upcase> but not <upcase> racional</upcase>";
           string  fixedText="";
            string upCaseTag = "<upcase>";
            string closeUpCaseTag = "</upcase>";
            int indexOfUpcase = text.IndexOf(upCaseTag, 0);
      
            int start =0;
         
           
            int indexOfEndUpCase = text.IndexOf(closeUpCaseTag,0);
   
            while (indexOfEndUpCase > -1 && indexOfUpcase > -1)
            {
                string temp = text.Substring(indexOfUpcase + 7, indexOfEndUpCase - indexOfUpcase - 7);
               
                    fixedText =fixedText+ (text.Substring(start,indexOfEndUpCase-start)).Replace(temp, temp.ToUpper());
                    start = indexOfEndUpCase + 1;
                   // Console.WriteLine(fixedText);
                
                
               
                indexOfUpcase = text.IndexOf(upCaseTag, indexOfUpcase + 1);
                indexOfEndUpCase = text.IndexOf(closeUpCaseTag, indexOfEndUpCase + 1);
               
                
               
            }
            fixedText += text.Substring(start);
            string[] spliters = { "<upcase>", "/upcase>" };
           string[] fix= fixedText.Split(spliters, StringSplitOptions.None);
           StringBuilder final = new StringBuilder();
           foreach (var word in fix)
           {
               final.Append(word);
           }
           Console.WriteLine(final);
        }
    }
}
