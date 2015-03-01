using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Task_PrintLongSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSequence = 2;
            int secondSequence = -3;
            for (int i = 0; i < 10; i++)
            {
                firstSequence += 2;
                secondSequence -= 2;
                Console.Write("{0}  {1}", firstSequence, secondSequence);

            }
            Console.ReadKey();

        }
    }
}
