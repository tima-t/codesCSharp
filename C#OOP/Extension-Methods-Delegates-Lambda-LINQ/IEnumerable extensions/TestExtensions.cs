using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_extensions
{
    class TestExtensions
    {
        public static void Main()
        {
            IEnumerable<int> test = new int[] { 1, 2, 3, 4,5,6,7 };
            Console.WriteLine(test.SumMy());
            Console.WriteLine(test.AverageMy());
            Console.WriteLine(test.MultipleMy());
            IEnumerable<double> test1 = new List<double> { 1.5, 2.5, 3.5, 4.5, 5.5,6.5,7.5 };
            /////////////////////////////////////
            Console.WriteLine("with other list : ");
            Console.WriteLine(test1.SumMy());
            Console.WriteLine(test1.AverageMy());
            Console.WriteLine(test1.MultipleMy());
        }
    }
}
