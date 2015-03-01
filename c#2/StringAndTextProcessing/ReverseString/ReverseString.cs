using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
        public  static string Reverse(string text)
        {
            if (text == null) return null;

          
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
        static void Main()
        {
            Console.Write("write your string:  ");
            string text = Console.ReadLine();
            Console.WriteLine(Reverse(text));
        
            
        }
    }
}
