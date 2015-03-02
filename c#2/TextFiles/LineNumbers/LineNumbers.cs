using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            string fileName = @"..\..\LineNumbers.cs";
            StringBuilder newText = new StringBuilder();
            string newFileName = @"..\..\newTextWithLines.cs";
            WriteFile(ReadFile(fileName, newText), newFileName);// output files are in current folder


        }
        public static string ReadFile(string fileName,StringBuilder newText)
        {
            StreamReader streamReader1 = new StreamReader(fileName);
            using (streamReader1)
            {
                string fileLine = "start value";
                int counter=1;
                while (fileLine!=null)
                {
                    fileLine = streamReader1.ReadLine();
                    newText.Append(counter+"  " + fileLine+"\n");
                    counter++;
                }
               
                return newText.ToString();
            }
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

