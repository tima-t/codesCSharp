using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AppearanceCount
{
    public static int AppCount(int[] array,int k )
    {
        int counter=0;
        foreach (var number in array)
        {
            if (number==k)
            {
                counter++;
            }
        }
        return counter;
    }
    static void Main()
    {
        Console.Write("write your integer k ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("write you array of int  in a  single line and elements separated by coma");
        string[] array = (Console.ReadLine()).Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] array1 = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            array1[i] = int.Parse(array[i]);

        }
        Console.WriteLine("We met your  number {0} ,  {1} times in the array  ",k,AppCount(array1,k));
    }
}

