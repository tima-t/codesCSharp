using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToShort
{
    class BinaryShort
    {
        static void Main()
        {
            Console.Write("write your short  number : ");
            short yourShortNumber = short.Parse(Console.ReadLine());
            int i = 0;
            for (i = 31; i >= 0; i--)
            {
                if ((yourShortNumber & (1 << i)) != 0)
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
