/*Problem 5. The Biggest of 3 Numbers

    Write a program that finds the biggest of three numbers.
*/


using System;


    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            Console.Write("write you first real number \na= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("write you second real number \nb= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("write you third real number \nc= ");
            double c = double.Parse(Console.ReadLine());
            if (a >=b && a >= c)
            {
                Console.WriteLine("the biggest number is {0}",a);
            }
            if (c >= b && c >= a)
            {
                Console.WriteLine("the biggest number is {0}", c);
            }
            if (b >= a && b >= c)
            {
                Console.WriteLine("the biggest number is {0}", b);
            }
            Console.ReadLine();// pause 
        }
    }

