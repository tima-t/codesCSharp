using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordDictionary
{
    class WordDictionary
    {
        static void Main()
        {
            Dictionary<string,string> wordDict= new Dictionary<string,string>();
            wordDict.Add(".NET", "platform for applications from Microsoft");
            wordDict.Add("CLR", "managed execution environment for .NET");
            wordDict.Add("namespace", "hierarchical organization of classes");
            Console.WriteLine("write the world , that you want to get the meaning ");
            string word = Console.ReadLine();
            bool isExsisting = false;
            foreach (var key in wordDict)
            {
                if (word==key.Key)
                {
                    Console.WriteLine("the meaning of your word is:  {0}", key.Value);
                    isExsisting= true;

                }
            }
            if (!isExsisting)
            {
                Console.WriteLine("we dont have the searched word in our dictionary ");
            }

        }
    }
}
