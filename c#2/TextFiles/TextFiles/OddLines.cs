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
