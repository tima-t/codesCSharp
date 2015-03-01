using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            Console.WriteLine("write your message");
            string message = Console.ReadLine();
            for (int  i = 0;  i<message.Length; i++)
            {
                Console.Write("\\u{0:X4}",(int)message[i]);
                
            }
        }
    }
}
