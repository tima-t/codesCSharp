/*Problem 6. Maximal K sum

Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.
 */

using System;


namespace MaximalKSum
{
    class MaximalKSum
    {
        static void Main()
        {
            Console.Write("write your k number k= ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("write your n number n= ");
            int n = int.Parse(Console.ReadLine());
            long tempsum = 0;
            int start=0;
            int end=0;
            long maxsum = long.MinValue;
            int[] array1 = new int[n];
            if (k > n)
            {
                Console.WriteLine("wrong input");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("array1[{0}]=", i);
                    array1[i] = int.Parse(Console.ReadLine());

                }

                for (int i = 0; i < array1.Length; i++)
                {
                    if (i + k < n)
                    {

                        for (int j = i; j < k + i; j++)
                        {
                            tempsum += array1[j];


                        }

                    }
                    if (tempsum > maxsum)
                    {
                        maxsum = tempsum;
                        start = i;
                        end = k + i;
                    }
                    tempsum = 0;

                }

                Console.WriteLine("the max sum is {0}",maxsum);

                for (int i = start; i < end; i++)
                {
                    Console.Write("{0} ",array1[i]);
                }
                Console.WriteLine();
            }

            

        }
    }
}
