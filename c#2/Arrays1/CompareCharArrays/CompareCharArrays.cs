/*Problem 3. Compare char arrays

Write a program that compares two char arrays lexicographically (letter by letter).
 */

using System;

class CompareCharArrays
{
    static void Main()
    {

        Console.Write("write the count of elments of first array : ");
        int count1 = int.Parse(Console.ReadLine());
        Console.Write("write the count of elments of second array : ");
        int count2 = int.Parse(Console.ReadLine());
        char[] array1 = new char[count1];
        char[] array2 = new char[count2];
        bool flag = true;
        if (count1 == count2)
        {
            for (int i = 0; i < count1; i++)
            {
                Console.Write("array1[{0}]=", i);
                array1[i] = char.Parse(Console.ReadLine());

            }

            for (int i = 0; i < count1; i++)
            {
                Console.Write("array2[{0}]=", i);
                array2[i] = char.Parse(Console.ReadLine());

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

