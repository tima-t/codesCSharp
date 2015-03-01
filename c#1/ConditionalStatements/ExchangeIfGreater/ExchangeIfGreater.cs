/*Homework: Conditional Statements
Problem 1. Exchange If Greater

    Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

 */


using System;

    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.Write("write your first number\nnumber1= ");
            double number1 = double.Parse(Console.ReadLine());
            Console.Write("write your second number\nnumber2= ");
            double number2 = double.Parse(Console.ReadLine());
            if (number1 > number2)
            {
                double temp;
                temp = number1;
                number1 = number2;
                number2 = temp;
            }
            Console.WriteLine("{0} {1}",number1,number2);
            Console.ReadLine();//pause 
        }
    }

