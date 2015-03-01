/*Problem 4. Number Comparer

    Write a program that gets two numbers from the console and prints the greater of them.
    Try to implement this without if statements.

 */



using System;



    class NumberComparer
    {
        static void Main()
        {
            Console.Write("write the first number : ");
            float number1 = float.Parse(Console.ReadLine());
            Console.Write("write the second number : ");
            float number2 = float.Parse(Console.ReadLine());
            float greater;
           greater= number1 > number2 ?  number1 :  number2;
           Console.WriteLine("the greater number is {0}", greater);
           Console.ReadLine();//pause


        }
    }

