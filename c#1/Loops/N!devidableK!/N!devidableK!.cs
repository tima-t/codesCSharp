/*Problem 6. Calculate N! / K!

    Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
    Use only one loop.

 */

using System;



class Program
{
    static void Main()
    {
        Console.Write("write n between 1 and 100 \nn= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Write k between 1 and 100 \nx=  ");
        int k = int.Parse(Console.ReadLine());
        if (k < 1 || k > 100 || k > n || n > 100 || n < 1)
        {
            Console.WriteLine("wrong input ");
        }

        else
        {


           
           ulong nFact = 1;
          ulong  kFact = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i == k)
                {


                    for (int j = 1; j <= i; j++)
                    {
                        kFact = kFact * (ulong) j;
                    }
                }
                if (i==n){
                    for (int j = 1; j <= i; j++)
                    {
                        nFact =nFact* (ulong)j;
                    }

                }


              
            }
            Console.WriteLine("the result n!/k!  is {0}", nFact/kFact);
           
        
         
        }
        Console.ReadLine();// pause
    }
}

