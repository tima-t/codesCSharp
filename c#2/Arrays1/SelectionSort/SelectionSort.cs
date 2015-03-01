/*
 */

using System;



class SelectionSort
{

    public static int[] selectionSort(int[] array)
    {
        int i, j, min, temp;
        for (i = 0; i < array.Length - 1; i++)
        {
            min = i;
            for (j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }
            temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }
        return array;
    }
    static void Main()
    {
        Console.Write("write the count of elments of first array : ");
        int count1 = int.Parse(Console.ReadLine());
        int[] arr = new int[count1];
        for (int i = 0; i < count1; i++)
        {
            Console.Write("array1[{0}]=", i);
            arr[i] = int.Parse(Console.ReadLine());

        }
        selectionSort(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("array1[{0}]={1}", i, arr[i]);


        }
    }
}

