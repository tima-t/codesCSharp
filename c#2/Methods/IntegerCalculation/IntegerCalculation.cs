using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerCalculation
{
    class IntegerCalculation
    {
        public static int Min(int [] array)
        {
            return array.Min();
        }

        public static int Max(int[] array)
        {
            return array.Max();
        }

        public static double Average(int[] array)
        {
            return array.Average();
        }

        public static int  Sum(int[] array)
        {
            return array.Sum();
        }

        public static long  Product(int[] array)
        {
            long product = 1;
            foreach (var item in array)
            {
                product *= item;
                
            }
            return product;
           
                
            
        }


        static void Main()
        {
            Console.WriteLine("write you collection of integers on a single line , separated by coma ");
            string mass = Console.ReadLine();
            if (mass.Length < 1)
            {
                Console.WriteLine("your array shoud Not be empty ");
                return;
            }
            int[] array = (mass).Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => Convert.ToInt32(n)).ToArray();
            Console.WriteLine(" the min is {0}", Min(array));
            Console.WriteLine(" the max is {0}", Max(array));
            Console.WriteLine("The average is {0:0.00}",Average(array));
            Console.WriteLine(" the product is   {0}", Product(array));
        }
    }
}
