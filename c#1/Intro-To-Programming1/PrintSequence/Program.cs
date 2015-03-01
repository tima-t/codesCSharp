using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            int sequence1 = 2;
            int sequence2 = -3;
            Console.WriteLine("The sequence is :");
            for (int i = 0; i < 10; i++ )
            {
               
                Console.Write("{0} {1} ", sequence1, sequence2);
                sequence1 = sequence1 + 2;
                sequence2 = sequence2 - 2;
                

            }
            Console.ReadLine();// like pause 
        }
    }
}
