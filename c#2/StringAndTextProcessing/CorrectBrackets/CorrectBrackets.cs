using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main()
        {
            Console.Write("write your expression :");
            string expresion = Console.ReadLine();
            int openBracket = 0;
            int closeBracket = 0;
            foreach (var sign in expresion)
            {
                if (sign.Equals('('))
                {
                    openBracket++;
                }
                if (sign.Equals(')'))
                {
                    closeBracket++;
                }
            }
            if (openBracket.Equals(closeBracket))
            {
                Console.WriteLine("correct Expression");
            }
            else
            {
                Console.WriteLine("Incorect Expression ");
            }
        }
    }
}
