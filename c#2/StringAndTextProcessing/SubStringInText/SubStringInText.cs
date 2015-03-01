using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubStringInText
{
    class SubStringInText
    {
        static void Main()
        {
            Console.Write("write your text  :");
            string text = Console.ReadLine();
            Console.Write("write your sub- string  :");
            string subString = Console.ReadLine();
            int index =  text.IndexOf(subString, 0);
            int count = 0;
            while (index > -1)
            {
               index= text.IndexOf(subString,index+1);
               count++;
            }
            Console.WriteLine("We met your Substring {0} times",count);
        }
    }
}
