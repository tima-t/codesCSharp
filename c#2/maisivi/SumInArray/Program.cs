using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumInArray
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter sum: ");
            int sum = int.Parse(Console.ReadLine());
            Console.Write("Enter array size: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Element {0} = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            string elements = "";
            StringBuilder currentElements = new StringBuilder();
            
            for (int i = 0; i < array.Length; i++)
            {
                int currentSum = 0;
                for (int j = i; j < array.Length; j++)
                {
                    currentSum += array[j];
                    currentElements.AppendFormat("{0} ", array[j]);
                    if (currentSum == sum)
                    {
                        elements = currentElements.ToString();
                        Console.WriteLine("The sequence of given sum is: {0}", elements);
                    }
                    if (currentSum > sum)
                    {
                        currentSum = 0;
                        currentElements.Clear();
                        break;
                    }
                }
            }
        }
    }
}
