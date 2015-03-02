using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SaveSortedNames
{
    class SaveSortedN
    {
        static void Main()
        {
            string fileName = @"..\..\NamesList.txt";
            string outputText = @"..\..\NamesListOrdered.txt";
            List<string> names = ReadFile(fileName);
            names.Sort();
            WriteFile(names, outputText);// output files are in current folder


        }
        public static List<string> ReadFile(string fileName)
        {
            List<string> names = new List<string>();
            StreamReader streamReader1 = new StreamReader(fileName);
            using (streamReader1)
            {
                string currentName = streamReader1.ReadLine();
                while (currentName!=null)
                {
                    names.Add(currentName);
                     currentName = streamReader1.ReadLine();
                    
                }
                return names;
            }

        }

        public static void WriteFile(List<string> names , string nameOfNewFile)
        {
            StreamWriter streamWriter = new StreamWriter(nameOfNewFile);

            using (streamWriter)
            {
            
            for (int i = 0; i < names.Count; i++)
            {
                streamWriter.WriteLine(names[i]);
            }
           
           
                

            }

        }
    }
}
