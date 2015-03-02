using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CompareTextFiles
{
    class CompareTextFiles
    {
        static void Main()
        {
            string fileName1 = @"..\..\CompareTextFiles.cs";
            StringBuilder newText = new StringBuilder();
            string fileName2 = @"..\..\OddLines.cs";
            Console.WriteLine(ReadFile(fileName1,fileName2));
            // output files are in current folder
        }
        public static string ReadFile(string fileName1,string fileName2)
        {
            StreamReader streamReader1 = new StreamReader(fileName1);
            StreamReader streamReader2 = new StreamReader(fileName2);
            using (streamReader2)
            {


                using (streamReader1)
                {
                    string fileLine1 = "start value1";
                    string fileLine2 = "start value2";
                    int counterEqual = 0;
                    int counterDifferent = 0;
                    while (fileLine1 != null&& fileLine2!=null)
                    {
                        fileLine1 = streamReader1.ReadLine();
                        fileLine2 = streamReader2.ReadLine();
                        if (fileLine1==fileLine2)
                        {
                            counterEqual++;
                        }
                        else
                        {
                            counterDifferent++;
                        }
                    }
                    string result = "number of equal lines is " + counterEqual + " \n" + "number of different lines is " + counterDifferent;

                    return result;
                }
            }
        }
    }
}
