/*Problem 6. The Biggest of Five Numbers

    Write a program that finds the biggest of five numbers by using only five if statements.

 */

using System;


    class TheBiggstOf5Numbers
    {
        static void Main()
        {
            Console.Write("write you first real number \na= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("write you second real number \nb= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("write you third real number \nc= ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("write you first real number \nd= ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("write you second real number \ne= ");
            double e = double.Parse(Console.ReadLine());
            if (a >= b && a >= c && a>=d && a>=e)
            {
                Console.WriteLine("the biggest number is {0}", a);
            }
            if (c >= b && c >= a && c>=d&& c>=e)
            {
                Console.WriteLine("the biggest number is {0}", c);
            }
            if (b >= a && b >= c && b>=d && b>=e)
            {
                Console.WriteLine("the biggest number is {0}", b);
            }
            if (d >= b && d >= a && d>=c && d>=e)
            {
                Console.WriteLine("the biggest number is {0}", d);
            }
            if (e >= a && e >= c && e>=b && e>=d)
            {
                Console.WriteLine("the biggest number is {0}", e);
            }
            Console.ReadLine();// pause 
           
        }
    }

