/*Problem 7. Sort 3 Numbers with Nested Ifs


    Write a program that enters 3 real numbers and prints them sorted in descending order.
        Use nested if statements.
*/

using System;

class Sort3Numbers
{
    static void Main()
    {
        bool flag = true;// we use flag to catch the case where all numbersare equal 
        Console.Write("write you first real number \na= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("write you second real number \nb= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("write you third real number \nc= ");
        double c = double.Parse(Console.ReadLine());
        if (a >= b && a >= c && flag)
        {
            if (b >= c)
            {
                Console.WriteLine(" {0}, {1}, {2}", a, b, c);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", a, c, b);
            }
            flag = false;// here the flag is changed and we won't print for example 1 1 1 three times , but only one time *
        }
        if (c >= b && c >= a && flag)
        {
            if (a >= b)
            {
                Console.WriteLine(" {0}, {1}, {2}", c, a, b);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", c, b, a);
            }
           
        }
        if (b >= a && b >= c && flag)
        {
            if (a >= c)
            {
                Console.WriteLine(" {0}, {1}, {2}", b, a, c);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", b, c, a);
            }
          
        }
        Console.ReadLine();// pause 
    }
}

