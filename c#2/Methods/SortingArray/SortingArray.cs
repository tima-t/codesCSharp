using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArray
{
    class SortingArray
    {
        public static int ReturnMax(int[] array1)
        {
            Console.Write("write the begining  index : ");
            int index = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            for (int i = index; i < array1.Length; i++)
            {
                if (max < array1[i])
                {
                    max = array1[i];
                }
            }
            return max;
        }
        public static int ReturnMax1(int[] array1)
        {
            int temp = 0; 
            int max = int.MinValue;
            for (int i = 0; i < array1.Length; i++)
            {
                if (max < array1[i])
                {
                    max = array1[i];
                    temp = i;
                }
            }

            array1[temp] = int.MinValue;
            return max;
        }
        public static int[] ReturnInAscendingOrd(int[] array1)
        {
            int[] arrayAsc = new int[array1.Length];
            for (int i = arrayAsc.Length-1; i >= 0; i--)
            {
                arrayAsc[i] = ReturnMax1(array1);
            }
            return arrayAsc;
        }

        static void Main()
        {
            Console.WriteLine("write you array of int  in a  single line and elements separated by coma");
            string[] array = (Console.ReadLine()).Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] array1 = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array1[i] = int.Parse(array[i]);

            }

      
            Console.WriteLine("the  maximal element is {0}",ReturnMax(array1));

            Console.WriteLine("///////////////////");
            Console.WriteLine("///////////////////");
            int[] sortedArr = new int[array1.Length];
            sortedArr = (int[])ReturnInAscendingOrd(array1).Clone(); 
            foreach (var item in sortedArr  )
            {
                Console.Write("{0} , " ,item);
            }
            Console.WriteLine();
            Console.WriteLine("///////////////////");
            Console.WriteLine("///////////////////////");
            Console.WriteLine("in descending order");
            foreach (var item in sortedArr.Reverse())
            {
                Console.Write("{0} , ", item);
            }

        }
    }
}
