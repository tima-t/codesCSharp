using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExtractTextFromXml
{
    class ExtractTextFromXml
    {
        static void Main()
        {
            string fileName = @"..\..\XmlFile.txt";
            string fileOut = @"..\..\NoTags.txt";
            string text =  ReadFile(fileName);
            Console.WriteLine("Extraction Fiished!!");

            WriteFile(RemoveTags(text), fileOut);// output files are in current folder
        }

        public static string ReadFile(string fileName)
        {
            StreamReader streamReader1 = new StreamReader(fileName);
            using (streamReader1)
            {
                string fileContents = streamReader1.ReadToEnd();
                return fileContents;
            }

        }
        public static string RemoveTags(string text)
        {
            StringBuilder textWithoutTags = new StringBuilder(text);
            int indexOpen = 0;
            int indexClose = 0;
            if (text.IndexOf("<title>") > 0 && text.IndexOf("</title>") > 0)
            {
                Console.WriteLine("the title is {0}", text.Substring(text.IndexOf("<title>") + 7, text.IndexOf("</title>") - 7 - text.IndexOf("<title>")));
            }
            while (true)
            {
                indexOpen = text.IndexOf('<', indexOpen);
                indexClose = text.IndexOf('>', indexClose);

                if (indexOpen < 0 || indexClose < 0)
                {
                    break;

                }
                if (indexOpen >= 0 && indexClose >= indexOpen)
                {
                    textWithoutTags.Remove(indexOpen, indexClose + 1 - indexOpen);
                    textWithoutTags.Insert(indexOpen, new string(' ', indexClose + 1 - indexOpen));
                }


                indexOpen++;
                indexClose++;

            }
            string temp = textWithoutTags.ToString();
            char[] seps = { ' ' };
            string[] final = temp.Split(seps, StringSplitOptions.RemoveEmptyEntries);
             return string.Join(" ", final);
        }
        public static void WriteFile(string contents, string nameOfNewFile)
        {
            StreamWriter streamWriter = new StreamWriter(nameOfNewFile);
            using (streamWriter)
            {
                streamWriter.WriteLine(contents);

            }

        }
    }
}
