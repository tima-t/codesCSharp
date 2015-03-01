using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToDec
{
    class HexToDec
    {
        static void Main()
        {
            bool check = true;
            Console.Write("write your Hexadecimal number: ");
            string hexadecimalNumber = Console.ReadLine();
            byte counter = 0;
            long decimalNumber = 0;
            for (int i = hexadecimalNumber.Length - 1; i >= 0; i--)
            {
                if (hexadecimalNumber[i] >= 'A' && hexadecimalNumber[i] <= 'F')
                {
                    decimalNumber += (long)((hexadecimalNumber[i] - 55) * Math.Pow(16, counter));



                }
                else if (hexadecimalNumber[i] >= '0' && hexadecimalNumber[i] <= '9')
                {
                    decimalNumber += (long)((hexadecimalNumber[i] - 48) * Math.Pow(16, counter));

                }
                else
                {
                    check = false;
                    Console.WriteLine("your hexadecimal number is not written in right format ");
                    break;
                }

                counter++;


            }
            if (check == true)
            {
                Console.WriteLine("your hexadecima {0} number into decimal number is {1} ", hexadecimalNumber, decimalNumber);
            }
        }
    }
}
