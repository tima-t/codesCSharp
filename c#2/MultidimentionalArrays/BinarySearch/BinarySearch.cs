using System;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            Console.Write( "write your int array in a line and elements separated by coma ");
            string[] array = (Console.ReadLine()).Split( new char[]{',',' '}, StringSplitOptions.RemoveEmptyEntries);
            Console.Write("write your integer k ");
            int k = int.Parse(Console.ReadLine());
            int[] array1 = new int [array.Length];
           
            for (int i  = 0; i  <array.Length; i ++)
            {
                array1[i] = int.Parse(array[i]);
                
            }
            Array.Sort(array1);
            int index=(Array.BinarySearch(array1, k));
            if (index < 0)
            {
                index = Math.Abs(index) - 2;
            }
            Console.WriteLine("you can see and the sorted array for sure {0}", String.Join(",", array1));
            Console.WriteLine("the index of searched element is {0}",index);
            Console.WriteLine("the searched element is {0}",array1[index]);
            
           
        }
    }
}
