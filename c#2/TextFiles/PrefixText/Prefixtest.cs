using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrefixText
{
    class Prefixtest
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader(@"..\..\StartFile.txt"))
            {
                using (StreamWriter output = new StreamWriter(@"..\..\WithouPrefixTest.txt"))
                {
                    string line = reader.ReadLine();
                    string fixedLine = "";
                    while (line != null)
                    {
                        string[] words = line.Split(' ');
                        for (int i = 0; i < words.Length; i++)
                        {

                            if (words[i].Length >= 4)
                            {
                                


                                if (words[i].Substring(0, 4) != "test")
                                {
                                    fixedLine += words[i]+ " ";
                                }
                            }
                            else
                            {
                                fixedLine += words[i]+ " ";
                            }
                        }

                        output.WriteLine(fixedLine);// output files are in current folder
                        fixedLine = "";

                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
