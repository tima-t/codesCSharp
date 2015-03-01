using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsArray
{

    class NumberAsArray
    {
        public static void ReverseCharArray()
        {
            Console.WriteLine("write your first number ");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("write your second number ");
            string secondNumber = Console.ReadLine();
            char[] firstNum = firstNumber.ToArray();
            char[] sedondNum = secondNumber.ToArray();
            Array.Reverse(firstNum);
            Array.Reverse(sedondNum);

            foreach (var item in firstNum)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            foreach (var item in sedondNum)
            {
                Console.Write(item);
            }
            Console.WriteLine();

        }
        static void Main()
        {
            ReverseCharArray();
        }
    }
}
