using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderWords
{
    class OrderWords
    {
        static void Main()
        {
            Console.WriteLine("write a list of words separated by space : ");
            string text = Console.ReadLine();
            char[] seps={' ',',','.'};
            string[] words = text.Split(seps, StringSplitOptions.RemoveEmptyEntries);
             Array.Sort(words);
             Console.WriteLine(string.Join(",",words));
        }
    }
}
