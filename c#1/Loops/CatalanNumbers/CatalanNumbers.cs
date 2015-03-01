/*Problem 8. Catalan Numbers

    In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
    Write a program to calculate the nth Catalan number by given n (1 <= n <= 100).
*/
using System.Numerics;
using System;



    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("write n\nn= ");
            int n = int.Parse(Console.ReadLine());
            BigInteger nFact = 1;
            BigInteger n2Fact = 1;
            BigInteger n1Fact = 1;

            if (n < 0 || n > 100)
            {
                Console.WriteLine("wrong input ");
            }
            else
            {
                for (int i = 1; i <= 2 * n; i++)
                {
                    if (i <= n)
                    {
                        nFact = nFact * i;
                    }
                    if (i<=(2*n)){
                        n2Fact = n2Fact * i;

                    }




                }
                n1Fact = nFact * (n + 1);
                BigInteger result = n2Fact / (n1Fact * nFact);
                Console.WriteLine("the result is {0}",result);

            }
            Console.ReadLine();//pause
        }
    }

