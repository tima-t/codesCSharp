//Write a program that finds the index of given element in a sorted 
//array of integers by using the binary search algorithm (find it in Wikipedia).
using System;

class BinarySearch
{
    static void Main()
    {
        int[] array = EnterArray();
        Array.Sort(array);

        int num = EnterTheNum();

        FindTheIndex(array, num);
    }

    private static void FindTheIndex(int[] array, int num)
    {
        int low = 0;
        int high = array.Length - 1;

        while (low <= high)
        {
            int middle = (low + high) / 2;
            if (array[middle] > num)
            {
                high = middle - 1;
            }
            else if (array[middle] < num)
            {
                low = middle + 1;
            }
            else
            {
                Console.WriteLine("The index of {0} is {1}.", num, middle);
                break;
            }
        }
    }

    private static int EnterTheNum()
    {
        Console.Write("Enter the number you look for: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    private static int[] EnterArray()
    {
        Console.Write("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());

        int[] array = new int[length];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter value for array[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }
}