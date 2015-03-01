/*Problem 10. Odd and Even Product

    You are given n integers (given in a single line, separated by a space).
    Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
    Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

 */

using System;


namespace OddAndEvenProduct
{
    class OddAndEvenProducts
    {
        static void Main()
        {
            int sum1 = 1;
            int sum2 = 1;
            Console.WriteLine("write your integer numbers on a line separated by a space :");
            string numbers = Console.ReadLine();
            string[] parts = numbers.Split(new char[] { ' ' });
            for (int i = 0; i < parts.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum1 *=int.Parse( parts[i]);
                }
                else
                {
                    sum2 *= int.Parse(parts[i]);
                }

            }

            if (sum1 == sum2)
            {
                Console.WriteLine("the product is equal {0}",true);
            }

            else
            {
                Console.WriteLine("the product is equal {0} ", false);
            }
            Console.ReadLine();
            
        }
    }
}
