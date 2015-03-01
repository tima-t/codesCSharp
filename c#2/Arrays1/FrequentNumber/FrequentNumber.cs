/*Problem 9. Frequent number

Write a program that finds the most frequent number in an array.
 */

using System;


namespace FrequentNumber
{
    class FrequentNumber
    {
        static void Main()
        {
            Console.Write("Enter length of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            int maxCount = 0;
            int count = 0;
            int frequenNumber=0;
            for (int i = 0; i < size; i++)
            {
                Console.Write("arr[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }


                }

                if (count > maxCount)
                {
                    maxCount = count;
                    frequenNumber = array[i];
                }
                count = 0;
            }

            Console.WriteLine("{0}({1} times)",frequenNumber,maxCount);

        }
    }
}
