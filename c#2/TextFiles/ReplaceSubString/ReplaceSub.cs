using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace ReplaceSubString
{
    class ReplaceSub
    {
        static void Main()
        {
            string inputFile = @"..\..\InpFile.txt";
            string outputFile = @"..\..\OutFile.txt";
            using (StreamReader reader = new StreamReader(inputFile))
            {
                string currentLine;
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    while (!reader.EndOfStream)
                    {
                        currentLine = reader.ReadLine();
                        currentLine = Regex
                        .Replace(currentLine, "start", "finish", RegexOptions.IgnoreCase);
                        writer.WriteLine(currentLine);
                    }
                    Console.WriteLine("DIRECTORY: " +
                    Path.GetFullPath(outputFile).Replace(Path.GetFileName(outputFile), String.Empty));
                    Console.WriteLine("A file {0} has been created with the replaced text.",
                    Path.GetFileName(outputFile));// output files are in current folder
                }
            }

        }    
    }
}
        
    

