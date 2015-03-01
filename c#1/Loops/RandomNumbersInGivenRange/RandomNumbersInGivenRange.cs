/*Problem 11. Random Numbers in Given Range

    Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

 */

using System;



    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            Console.Write("write n\nn= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("write down custom \ndown= ");
            int down = int.Parse(Console.ReadLine());
            Console.Write("write high custom \nhigh= ");
            int high = int.Parse(Console.ReadLine());
            if (high <= down)
            {
                Console.WriteLine("wrong input high should be bigger than down");
            }
            else
            {
                Random r = new Random();
                int rInt;
                for (int i = 0; i < n; i++)
                {
                    rInt = r.Next(down, (high+1));
                    Console.Write("{0} ",rInt);
                }
                
           

            }
            Console.ReadLine();
        }
    }

