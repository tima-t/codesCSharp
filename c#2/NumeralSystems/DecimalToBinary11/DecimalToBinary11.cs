using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary11
{
    class DecimalToBinary11
    {
        static void Main()
        {
            Console.Write("write your decimal number : ");
            long yourDecimalNumber = long.Parse(Console.ReadLine());
            int i = 0;
            for (i = 31; i >= 0; i--)
            {
                if ((yourDecimalNumber & (1 << i)) != 0)
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0");
                }
              
            }
            Console.WriteLine();
        }
    }
}
