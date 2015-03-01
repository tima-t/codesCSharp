/*Problem 14. Decimal to Binary Number

    Using loops write a program that converts an integer number to its binary representation.
    The input is entered as long. The output should be a variable of type string.
    Do not use the built-in .NET functionality.

 */

using System;

class DecimalToBinary
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
        Console.ReadLine();// pause
    }
}

