using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DeleteOddLines
{
    class DeleteOdd
    {
        static void Main()
        {
            string fileName = @"..\..\DeleteOdd.cs";



            Console.WriteLine("\n\n We will write the even lines - line by line:");
            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                using (StreamWriter writerOut = new StreamWriter(@"..\..\EvenLines.txt"))
                {
                    int lineNumber = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        if (lineNumber % 2 == 0)
                        {
                            writerOut.WriteLine(lineNumber + " " + line);// output files are in current folder
                        } 

                        line = reader.ReadLine();
                        lineNumber++;
                    }
                }
            }
        }
    }
}
