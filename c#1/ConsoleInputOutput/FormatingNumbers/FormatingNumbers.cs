/*
    Write a program that reads 3 numbers:
        integer a (0 <= a <= 500)
        floating-point b
        floating-point c
    The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
        The number a should be printed in hexadecimal, left aligned
        Then the number a should be printed in binary form, padded with zeroes
        The number b should be printed with 2 digits after the decimal point, right aligned
        The number c should be printed with 3 digits after the decimal point, left aligned.

 */

using System;



class FormatingNumbers
{
    static void Main()
    {
        Console.Write("write and integer between 0 and 500: ");
        short firstNumber = short.Parse(Console.ReadLine());
        if (0 <= firstNumber && firstNumber <= 500)
        {
            Console.Write("write a number with floating point ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("write a number with floating point ");
            double thirdNumber = double.Parse(Console.ReadLine());
            string firstNumberToBinary = Convert.ToString(firstNumber, 2).PadLeft(10, '0');
            string firstNumberToHexadecimal = firstNumber.ToString("X");         
            Console.WriteLine("|{0,-10}|{1,10}|{2,10:0.00}|{3,-10:0.000}|",firstNumberToHexadecimal,firstNumberToBinary,secondNumber,thirdNumber);

        }
        else
        {
            Console.WriteLine("Wrong Input , your integer number shoud be between 0 and 500");
        }
        Console.ReadLine();//pause
    }
}

