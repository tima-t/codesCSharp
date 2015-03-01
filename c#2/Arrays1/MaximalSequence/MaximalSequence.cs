/*Problem 4. Maximal sequence

Write a program that finds the maximal sequence of equal elements in an array.
 */
using System;

class MaximalSequence
{
    static void Main()
    {
        Console.Write("write the count of elments of first array : ");
        int count1 = int.Parse(Console.ReadLine());
        int[] array1 = new int[count1];
        int temp = 0;
        bool flag = true;
        int numberOfSequence = 0;
        int max = int.MinValue;
        int searchedNumber = 0;

        for (int i = 0; i < count1; i++)
        {
            Console.Write("array1[{0}]=", i);
            array1[i] = int.Parse(Console.ReadLine());

        }

        for (int i = 0; i < array1.Length; i++)
        {
            if (flag == true)
            {
                temp = array1[i];
                flag = false;

            }
            if (temp == array1[i])
            {
                numberOfSequence++;

            }
            if (temp != array1[i] || i == (array1.Length - 1))
            {
                if (numberOfSequence > max)
                {
                    max = numberOfSequence;
                    searchedNumber = temp;
                }
                numberOfSequence = 1;

                flag = true;

            }



        }
        for (int i = 0; i < max; i++)
        {
             if (i < max - 1)
             {
            Console.Write("{0},", searchedNumber);
             }
             else
             {
                 Console.WriteLine(searchedNumber);
             }

        }
        


    }
}

