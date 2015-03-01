using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.Write("write your binary number: ");
            string binaryNumber = Console.ReadLine();
            long decimalNumber = 0;
            byte count = 0;
            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                if (binaryNumber[i] == '1')
                {
                    decimalNumber += (long)Math.Pow(2, count);
                }
                count++;
            }
            Console.WriteLine("after convert the decimal number is {0}", decimalNumber);
        }
    }
}
