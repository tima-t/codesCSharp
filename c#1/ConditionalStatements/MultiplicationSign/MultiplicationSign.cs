/*Problem 4. Multiplication Sign

    Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
        Use a sequence of if operators.
*/

using System;

    class MultiplicationSign
    {
        static void Main()
        {
            Console.Write("write you first real number \na= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("write you second real number \nb= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("write you third real number \nc= ");
            double c = double.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            if (a > 0 && b > 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            if (a > 0 && b < 0 && c > 0)
            {
                Console.WriteLine("-");
            }
            if (a < 0 && b > 0 && c > 0)
            {
                Console.WriteLine("-");
            }
            if (a > 0 && b < 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            if (a < 0 && b > 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            if (a < 0 && b < 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("0");
            }
            Console.ReadLine();//pause

        }
    }

