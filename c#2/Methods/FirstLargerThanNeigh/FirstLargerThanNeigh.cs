using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerThanNeigh
{
    class FirstLargerThanNeigh
    {
        public static int LargThanNeighbour(int[] array)
        {

            for (int index = 1; index < array.Length - 1; index++)
            {





                if (array[index] > array[index + 1] && array[index] > array[index - 1])
                {
                   
                    return index;
                }


            }
           
            return -1;

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
            if (LargThanNeighbour(array1) > -1)
            {
                Console.WriteLine("the index of first number bigger than neighbours is {0}", LargThanNeighbour(array1));
            }
            else
            {
                Console.WriteLine("there is not such number ");
            }
        }
    }
}
