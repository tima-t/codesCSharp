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
           WriteFile(contents, @"..\..\newFileConcatTexts.cs");
           
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFiles
{
    class OddLines
    {
        static void Main()
        {
            string fileName = @"..\..\OddLines.cs";
            


            Console.WriteLine("\n\n We will print the odd lines - line by line:");
            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (lineNumber%2==1)
                    {
                        Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    }
                    
                    line = reader.ReadLine();
                    lineNumber++;
                }
            }
        }
    }
}

