using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentences
{
    class ExtractSentences
    {
        static void Main()
        {
            Console.Write("write the word : ");
            string word= Console.ReadLine();
            Console.WriteLine("The text is:");
            string text = " We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            int tempIndex=1;
          StringBuilder result=new StringBuilder();
         
          char[] sep = { '.','!','?' };
          string []sentences = text.Split(sep);
          for (int i = 0; i < sentences.Length; i++)
          {
              if (sentences[i].Contains(word))
              {
                  for (int j = 0; j < sentences[i].Length; j++)
                  {
                     tempIndex= sentences[i].IndexOf(word,tempIndex);
                     if (tempIndex<0)
                     {
                         tempIndex = 0;
                     }
                    
                     if (tempIndex>0)
                     {
                      

                         if (sentences[i][tempIndex - 1] == ' ' && sentences[i][tempIndex + word.Length ] == ' ')
                         {
                             result.Append(sentences[i]);
                             result.Append(".");
                            
                             break;
                          

                         }
                     }
                     tempIndex++;
                  }
                  tempIndex = 1;
                 
              }
          }
         string resultStr= result.ToString();
          Console.WriteLine("{0}",resultStr);

     
        }
    }
}
