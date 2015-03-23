using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class TimerTest
    {
        public static void Main()
        {


            Timer tim = new Timer(3);
            tim.SomeMethods = Print;
            tim.SomeMethods += PrintAg;
            tim.ExecuteMethods();
        }


        public static void Print()
        {
            Console.WriteLine("I like programming");

        }

        public static void PrintAg( )
        {

            Console.WriteLine("second func");
        }
    }
}
