using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatNumber
{
    class FormatNumber
    {
        static void Main()
        {
            Console.Write("Write your number: ");
            int numb = int.Parse(Console.ReadLine());
            Console.WriteLine("{0,15}", numb);
            Console.WriteLine("{0,15:X}", numb);
            Console.WriteLine("{0,15:P}", numb/100);
            Console.WriteLine("{0,15:E}", numb);
        }
    }
}
