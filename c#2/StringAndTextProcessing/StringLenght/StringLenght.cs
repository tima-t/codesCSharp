using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLenght
{
    class StringLenght
    {
        static void Main()
        {
            Console.WriteLine("write your string max 20 chars");
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            result.Append(text);
            if (text.Length>20)
            {
                   result.Remove(20,text.Length-20);
            }
            if (text.Length<20)
            {
                result.Append('*',20-text.Length);
            }
            Console.WriteLine("The result is {0} ",result);
           
        }
    }
}
