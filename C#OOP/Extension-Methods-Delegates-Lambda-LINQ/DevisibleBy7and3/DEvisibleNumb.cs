using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevisibleBy7and3
{
    class DEvisibleNumb
    {
        static void Main(string[] args)
        {
            var array = new int[29];
            for (int i = 0; i < 29; i++)
            {
                array[i] = i;
            }
            Console.WriteLine("the numbers in array are : {0} ",String.Join(",",array));
            var devisible1 = from num in array
                            where (num % 3 == 0 && num % 7 == 0)
                            select num;
            Console.WriteLine("devesible by 3 and 7 : {0}",String.Join(",",devisible1));
            var devisible2 = array.Where(n => (n % 7 == 0 && n % 3 == 0));
            Console.WriteLine("devisible by 3 and 7 second way : {0} ",String.Join(",",devisible2));
        }
    }
}
