/*Problem 11. Binary search

Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
 */


using System;



    class BinarySearch
    {
        static void Main()
        {
            Console.Write("Enter length of the array: ");
            int size = int.Parse(Console.ReadLine());
            Console.Write("write the searched element: ");
            int target = int.Parse(Console.ReadLine());
           

            
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("arr[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            int mid = 0, first = 0, last = array.Length - 1;
            bool found = false;
            while (!found && first <= last)
            {
                mid = (first + last) / 2;

                if (target == array[mid])
                {
                    found = true;
                    Console.WriteLine("the searched element is {0} on position {1}",target,mid);
                    break;
                }
                else
                {

                    if (target > array[mid])
                    {
                        first = mid + 1;
                    }

                    if (target < array[mid])
                    {
                        last = mid - 1;
                    }

                }

            }

        }
    }

