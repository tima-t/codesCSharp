/*Problem 7. Calculate N! / (K! * (N-K)!)

    In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
    Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
*/
using System.Numerics;
using System;



    class CalculateCombination
    {
        static void Main()
        {
            Console.Write("write n between 1 and 100 \nn= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Write k between 1 and 100 \nk=  ");
            int k = int.Parse(Console.ReadLine());
            if (k < 1 || k > 100 || k > n || n > 100 || n < 1)
            {
                Console.WriteLine("wrong input ");
            }
            else
            {



                BigInteger nFact = 1;
                BigInteger kFact = 1;
               BigInteger knFact = 1;

                for (int i = 1; i <= n; i++)
                {
                    if (i <= k)
                    {
                        kFact = kFact*(ulong) i;


                       
                    }
                    if (i <= n)
                    {
                        nFact =nFact* (ulong)i;

                    }
                     if (i <= (n-k))
                    {
                        knFact =knFact* (ulong)i;

                    }


                }

                BigInteger result = nFact / (kFact * knFact);

                Console.WriteLine("the result n!/(k!(k-n)!  is {0}", result);



            }
            Console.ReadLine();// pause
        }
    }

