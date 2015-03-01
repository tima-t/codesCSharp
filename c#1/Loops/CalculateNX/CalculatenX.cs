/*Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

    Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
    Use only one loop. Print the result with 5 digits after the decimal point.
  */


using System;


    class CalculatenX
    {
        static void Main()
        {
            Console.Write("write n\nn= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Write x\nx=  ");
            double x = double.Parse(Console.ReadLine());
            double sum = 1;
            double nFact = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    nFact *= j;
                }

                sum = sum + (nFact / (Math.Pow(x, i)));

                // Console.WriteLine("{0} {1}",nFact, (Math.Pow(x, i)));  to check the code 
                nFact = 1;
            }
            Console.WriteLine("the sum is {0:F5}", sum);
            Console.ReadLine();// pause

        }
        
    }

