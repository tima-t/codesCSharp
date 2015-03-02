using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConcatenateTextFiles
{
    class ConcatTexts
    {
        static void Main()
        {
            string fileName = @"..\..\ConcatTexts.cs";
            Console.WriteLine("The contents of the file {0} is:", fileName);
            string fileName2 = @"..\..\OddLines.cs";
           string contents= ReadFile(fileName);
           contents += ReadFile(fileName2);
           WriteFile(contents, @"..\..\newFileConcatTexts.cs");// output files are in current folder
           
        }
        public static string ReadFile(string fileName)
        {
            StreamReader streamReader1 = new StreamReader(fileName);
            using (streamReader1)
            {
                string fileContents = streamReader1.ReadToEnd();
                Console.WriteLine(fileContents);
                return fileContents;
            }
          
        }
        public static void WriteFile(string contents,string nameOfNewFile)
        {
            StreamWriter streamWriter = new StreamWriter(nameOfNewFile);
            using (streamWriter)
            {
                streamWriter.WriteLine(contents);
               
            }

        }

    }
}
