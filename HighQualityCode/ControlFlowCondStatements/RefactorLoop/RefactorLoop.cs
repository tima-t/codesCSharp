using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorLoop
{
    class RefactorLoop
    {
        static void Main()
        {
            int i = 0;
            int[] numbers = new int[]
            {
                1,2,10,15,20,25
            };

            int endOfLoop = numbers.Length;
            int expectedValue = 1;
            for (i = 0; i < endOfLoop; i++)
            {
                if (i % 10 == 0 && numbers[i]==expectedValue)
                {
                        i = 666;
                        break;
                }             
                Console.WriteLine(numbers[i]);
            }
            // More code here
            if (i == 666)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
