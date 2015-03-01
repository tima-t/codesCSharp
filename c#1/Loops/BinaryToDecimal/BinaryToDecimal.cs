/*Problem 13. Binary to Decimal Number

    Using loops write a program that converts a binary integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality.
 */

using System;


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
            Console.ReadLine();//pause
        }
    }
}
