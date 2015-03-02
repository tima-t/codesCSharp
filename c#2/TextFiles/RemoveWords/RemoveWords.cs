using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;



namespace RemoveWords
{
    class RemoveWords
    {
        static void Main()
        {
            string allLines = String.Join(" ", File.ReadAllLines(@"..\..\StartFile.txt"));
            string[] allWords = allLines.Split(' ');
            using (StreamReader start = new StreamReader(@"..\..\File.txt"))
            {
                string line = start.ReadLine();
                using (StreamWriter finish = new StreamWriter(@"..\..\NewFile.txt"))
                {
                    while (line != null)
                    {
                        for (int i = 0; i < allWords.Length; i++)
                        {
                            string word = "\\b" + allWords[i] + "\\b";
                            line = Regex.Replace(line, word, "");
                        }
                        finish.WriteLine(line);// output files are in current folder
                        line = start.ReadLine();
                    }
                }
            }
        }
    }
}
