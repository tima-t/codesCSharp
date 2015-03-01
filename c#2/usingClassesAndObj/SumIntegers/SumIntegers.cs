using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumIntegers
{
    class SumIntegers
    {
        static void Main()
        {
            Console.WriteLine("write your secuence of inteegrs on a single line separated by space : ");
            string integers = Console.ReadLine();
            char[] sep = {' ',','};
            int[] numbers = integers.Split(sep, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
            Console.WriteLine("the sum of the numbers is {0}",numbers.Sum());
        }
    }
}
