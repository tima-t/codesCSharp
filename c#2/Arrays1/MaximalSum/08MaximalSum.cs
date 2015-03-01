/*
 */

using System;



    class MaximalSum
    {
        static void Main()
        {
            
            Console.Write("Enter length of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("arr[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            int curSum = array[0];
            int startIndex = 0;
            int endIndex = 0;
            int tempIndex = 0;
            int maxSum = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (curSum <= 0)
                {
                    startIndex = i;
                    curSum = 0;
                }

                curSum += array[i];

                if (curSum > maxSum)
                {
                    maxSum = curSum;
                    tempIndex = startIndex;
                    endIndex = i;
                }
            }
            Console.Write("The best sequance is: ");
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The max sum is: {0}", maxSum);
        }
    }

