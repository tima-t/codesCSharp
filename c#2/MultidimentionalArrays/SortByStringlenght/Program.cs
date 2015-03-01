using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortByStringlenght
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("write your words on a line separated by a  space ");

            string[] words = (Console.ReadLine()).Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);
            words = words.OrderBy(t => t.Length).ToArray();
            Console.WriteLine(string.Join(",",words));

           
        }
    }
}
