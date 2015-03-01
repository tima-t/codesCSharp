/*Problem 10. Fibonacci Numbers

    Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

 */


using System;

    class FibonacciNumbers
    {
        static void Main()
        {
            Console.Write("write unsigned n and then we will print n numbers from fibonacci sequence \n n= ");
            uint n = uint.Parse(Console.ReadLine());
            uint previous = 0;
            uint next = 1;
            uint temp;
            for (int i = 0; i < n; i++)
            {
                if (i < 2)
                {


                    Console.Write("{0}, ",i);
                }
                else{
                    temp = next;
                    next = next + previous;
                    previous = temp;
                    
                    Console.Write("{0}, ",next);
                }

            }
            Console.ReadLine();//pause
        }
    }

