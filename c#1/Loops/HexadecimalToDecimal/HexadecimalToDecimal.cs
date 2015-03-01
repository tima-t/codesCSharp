/*Problem 15. Hexadecimal to Decimal Number

    Using loops write a program that converts a hexadecimal integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality.

 */

using System;



class HexadecimalToDecimal
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
                decimalNumber +=(long) ((hexadecimalNumber[i] - 55) * Math.Pow(16, counter));
               
             

            }
            else if(hexadecimalNumber[i]>='0' && hexadecimalNumber[i]<='9')
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
        Console.ReadLine();//pause
            
    }
}

