/*Problem 5. Maximal increasing sequence

Write a program that finds the maximal increasing sequence in an array.
 */


using System;



class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Write("write the count of elments of first array : ");
        int count1 = int.Parse(Console.ReadLine());
        int[] array1 = new int[count1];
        int temp = 0;
        int tempStart = 0;
        int start = 0, end = 0;
        bool flag = true;
        int numberOfSequence = 0;
        int max = int.MinValue;
        

        for (int i = 0; i < count1; i++)
        {
            Console.Write("array1[{0}]=", i);
            array1[i] = int.Parse(Console.ReadLine());

        }

        for (int i = 0; i < array1.Length; i++)
        {
            if (flag == true)
            {
                if (i == 0)
                {
                    tempStart = i;
                }
                if(i!=0)
                {
                    tempStart = i - 1;
                }
                flag = false;

            }
          
                if (i == 0)
                {
                    numberOfSequence++;
                }


                else if (temp < array1[i])
                {
                    numberOfSequence++;
                   

                }
            
            if ((temp >= array1[i] || i == (array1.Length - 1))&& i!=0)
            {
                if (numberOfSequence > max)
                {
                    start = tempStart;
                    end = i;
                    max = numberOfSequence;
                    
                }
                numberOfSequence = 1;

                flag = true;

            }
            temp = array1[i];



        }
        for (int i = start; i < end; i++)
        {
            if (i < end - 1)
            {
                Console.Write("{0},", array1[i]);
            }
            else
            {
                Console.WriteLine(array1[i]);
            }

        }

    }
}

