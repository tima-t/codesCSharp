/*Problem 15. Prime numbers

Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
 */


using System;


namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main()
        {
            Console.Write("write the last number from the interval and we well print the prime numbers in interval[1....n] n= ");
            ulong n = ulong.Parse(Console.ReadLine());
            bool[] e = new bool[n];//by default they're all false
            for (ulong i = 2; i < n; i++)
            {
                e[i] = true;//set all numbers to true
            }
            //weed out the non primes by finding mutiples 
            for (ulong j = 2; j < n; j++)
            {
                if (e[j])//is true
                {
                    for (ulong p = 2; (p * j) < n; p++)
                    {
                        e[p * j] = false;
                    }
                }
            }
            for (ulong i = 2; i < n; i++)
            {
               if( e[i] ==true)
               {
                   Console.Write("{0} , ",i);
               }
            }
        }
    }
}
