using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

class CountWords
{
    static void Main()
    {
        try
        {
            // output files are in current folder
            string[] words = File.ReadAllLines(@"..\..\words.txt");
            int[] counter = new int[words.Length];
            using (StreamReader readWords = new StreamReader(@"..\..\test.txt"))
            {
                string line = readWords.ReadLine();
                while (line != null)
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        counter[i] = counter[i] + Regex.Matches(line, "\\b" + words[i] + "\\b").Count;
                    }
                    line = readWords.ReadLine();
                }
            }
            Array.Sort(counter, words);
            using (StreamWriter repeatedWords = new StreamWriter(@"..\..\result.txt"))
            {
                for (int i = words.Length - 1; i >= 0; i--)
                {
                    repeatedWords.WriteLine("{0}: {1}", words[i], counter[i]);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("{0}:{1}", e.GetType().Name, e.Message);
        }
        Console.WriteLine("Finish.");
    }
}
