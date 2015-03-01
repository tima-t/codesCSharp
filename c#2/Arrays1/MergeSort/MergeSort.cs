/*Problem 13.* Merge sort

Write a program that sorts an array of integers using the Merge sort algorithm.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

 

namespace CSharpSort

{

    class Program

    {

 

        static public void DoMerge(int [] numbers, int left, int mid, int right)

        {

            int [] temp = new int[25];

            int i, left_end, num_elements, tmp_pos;

        

            left_end = (mid - 1);

            tmp_pos = left;

            num_elements = (right - left + 1);

        

            while ((left <= left_end) && (mid <= right))

            {

                if (numbers[left] <= numbers[mid])

                    temp[tmp_pos++] = numbers[left++];

                else

                    temp[tmp_pos++] = numbers[mid++];

            }

        

            while (left <= left_end)

                temp[tmp_pos++] = numbers[left++];

 

            while (mid <= right)

                temp[tmp_pos++] = numbers[mid++];

 

            for (i = 0; i < num_elements; i++)

            {

                numbers[right] = temp[right];

                right--;

            }

        }

 

        static public void MergeSort_Recursive(int [] numbers, int left, int right)

        {

          int mid;

        

          if (right > left)

          {

            mid = (right + left) / 2;

            MergeSort_Recursive(numbers, left, mid);

            MergeSort_Recursive(numbers, (mid + 1), right);

        

            DoMerge(numbers, left, (mid+1), right);

          }

        }

        

 

        static void Main()

        {

            System.Console.WriteLine( "write your array on a single line and numbers devided by space : ");
            string[] numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
             int len = numbers.Length;
             int[] numbersArray = numbers.Select(x => int.Parse(x))
                .ToArray();
     

 

            Console.WriteLine("MergeSort By Recursive Method");

            MergeSort_Recursive(numbersArray, 0, len - 1);

            for (int i = 0; i < len; i++)
            {



                Console.WriteLine(numbersArray[i]);
            }
 

         

 

        }

    }
}
