using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbours
{

    class LargerThanNeighbours
    {
        public static void LargThanNeighbour(int[] array, int index)
        {

            if (index >= array.Length-1 || index==0)
            {
                Console.WriteLine("This element does not exist or has not two neighbours");
                return;
            }
            else
            {
                if (array[index] > array[index + 1] && array[index] > array[index - 1])
                {
                    Console.WriteLine("the elements is bigger than his neighbours");
                    return;
                }
                else
                {
                    Console.WriteLine("the elements is  not bigger than his neighbours");
                    
                }
            }

        }
        static void Main()
        {
            Console.Write("write the searched index ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("write you array of int  in a  single line and elements separated by coma");
            string[] array = (Console.ReadLine()).Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] array1 = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array1[i] = int.Parse(array[i]);

            }
            LargThanNeighbour(array1, index);
        }
    }
}
