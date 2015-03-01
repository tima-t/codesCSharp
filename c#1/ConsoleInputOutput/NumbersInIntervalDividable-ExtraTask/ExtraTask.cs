/*Problem 11.* Numbers in Interval Dividable by Given Number

    Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

 */

using System;



    class ExtraTask
    {
        static void Main()
        {
            Console.Write("write the down custom of the interval ");
            uint downCustom = uint.Parse(Console.ReadLine());
            Console.Write("write the up custom of the interval ");
            uint upCustom = uint.Parse(Console.ReadLine());
            uint dividableBy5InInterval=0;
            for (uint i = downCustom; i <= upCustom; i++)
            {
                if (i % 5 == 0)
                {
                    dividableBy5InInterval++;
                }

            }
            Console.WriteLine("the count of members in interval that are dividable by 5 is {0} ",dividableBy5InInterval);
            Console.ReadLine(); //pause


        }
    }

