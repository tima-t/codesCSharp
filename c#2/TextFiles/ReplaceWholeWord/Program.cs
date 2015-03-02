using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReplaceWholeWord
{
    class Program
    {
        static void Main()
        {
            using (StreamReader input = new StreamReader( @"..\..\Inp.txt"))
            {
                using (StreamWriter writerOut = new StreamWriter(@"..\..\output.txt"))// output files are in current folder
                {
                    for (string line = input.ReadLine(); line != null; line = input.ReadLine())
                    {
                        for (int i = line.IndexOf("start"); i != -1; i = line.IndexOf("start", i + 1))
                        {
                            if ((i - 1 < 0 || !Char.IsLetter(line[i - 1])) && (i + 5 >= line.Length) || !Char.IsLetter(line[i + 5]))
                            {
                                line = line.Insert(i, "finish").Remove(i + 6, 5);
                            }
                        }
                        writerOut.WriteLine(line);
                    }
                }
            }
        }
    }
}
