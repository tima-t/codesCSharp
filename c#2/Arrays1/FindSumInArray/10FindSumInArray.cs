/*Problem 10. Find sum in array

Write a program that finds in given array of integers a sequence of given sum S (if present).
 */

using System;



class Program
{
    static void Main()
    {
        Console.Write("write sum  s= ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("write your n number n= ");
        int n = int.Parse(Console.ReadLine());
        long tempsum = 0;
        int start = 0;
        int end = 0;
        int count = 0;
        long maxsum = long.MinValue;
        int[] array1 = new int[n];
        int[] array2 = new int[100];


        for (int i = 0; i < n; i++)
        {
            Console.Write("array1[{0}]=", i);
            array1[i] = int.Parse(Console.ReadLine());

        }

        for (int i = 0; i < array1.Length; i++)
        {
            start = i;
            for (int j = i; j < array1.Length; j++)
            {

                tempsum += array1[j];
                if (tempsum == s)
                {
                    array2[count] = start;
                    array2[count + 1] = j;
                    
                    count += 2;
                    tempsum = 0;
                    start = j+1;
                }



            }
            tempsum = 0;




        }



        for (int i = 0; i <count; i+=2)
        {
            for (int j = array2[i]; j <=array2[i+1]; j++)
            {
                Console.Write("{0} ",array1[j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();





    }
}

