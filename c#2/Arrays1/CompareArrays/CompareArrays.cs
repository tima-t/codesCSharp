/*Problem 2. Compare arrays

Write a program that reads two integer arrays from the console and compares them element by element.
 */

using System;



class CompareArrays
{
    static void Main()
    {
        Console.Write("write the count of elments of first array : ");
        int count1 = int.Parse(Console.ReadLine());
        Console.Write("write the count of elments of second array : ");
        int count2 = int.Parse(Console.ReadLine());
        int[] array1 = new int[count1];
        int[] array2 = new int[count2];
        bool flag = true;
        if (count1 == count2)
        {
            for (int i = 0; i < count1; i++)
            {
                Console.Write("array1[{0}]=", i);
                array1[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < count1; i++)
            {
                Console.Write("array2[{0}]=", i);
                array2[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < count1; i++)
            {
                if (array1[i] != array2[i])
                {
                    Console.WriteLine("arrays are  not equal ");
                    flag = false;
                    break;

                }

            }

            if (flag == true)
            {
                Console.WriteLine("arrays are equal");
            }



        }
        else
        {
            Console.WriteLine("arrays  are not equal");
        }
    }
}

