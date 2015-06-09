using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    class RangeExceptionsTest
    {


        static void Main()
        {
            try
            {
                throw new InvalidRangeException<int>("Invalid input!", 77, 173);
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\n\n");

            try
            {
                throw new InvalidRangeException<DateTime>("Invalid date!", new DateTime(1994, 1, 11), DateTime.Now);
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
