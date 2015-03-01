using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTasks
{

    class SolveTasks
    {
        public static void GetAverage()
        {
            Console.WriteLine("write you collection of integers on a single line , separated by coma ");
            string mass = Console.ReadLine();
            if (mass.Length<1)
            {
                Console.WriteLine("your array shoud Not be empty ");
                return;
            }
            int[] array = (mass).Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => Convert.ToInt32(n)).ToArray();
            Console.WriteLine(" the average is {0:0.0000}",array.Average()); 
            
        }


        public static int Menu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("////////////////////To Reverses the digits of a number press 1  /////// ");
            Console.WriteLine("///To Calculates the average of a sequence of integers press 2  ///////");
            Console.WriteLine("/////////////To Solves a linear equation a * x + b = 0 press 3  /////// ");
            Console.WriteLine("//////////////////////////////////To close the program press 4  /////// ");
            int choise= 4 ;
            bool ch = int.TryParse(Console.ReadLine(),out choise);
            if (!ch)
            {
                Console.WriteLine("wrong input");
            }
            return choise;


        }
        public static void Reverse()
        {
            bool flag = true;
            Console.Write("write your number: ");
            string number = Console.ReadLine();
            if (int.Parse(number) < 0)
            {
                Console.WriteLine("the number shoud be positive ");
                return;
            }
            Console.WriteLine("the reversed number is : ");
            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (number[0] == '-' && flag == true)
                {
                    Console.Write('-');
                    flag = false;


                }

                else if (number[0] == '-' && i == 0)
                {
                    Console.WriteLine();
                    return;
                }


                Console.Write(number[i]);


            }
            Console.WriteLine();
        }
        public static void SolvePolynom()
        {
            Console.Write("a = ");
            double a;
            bool tr = double.TryParse(Console.ReadLine(), out a);
            Console.Write("b = ");
            double b;
            bool tr1 = double.TryParse(Console.ReadLine(), out b);
            if (tr==false || tr1==false)
            {
                Console.WriteLine("wrong input ");
                return; 
            }
            if (a==0)
            {
                Console.WriteLine("a cant be 0");
                return;
            }
            Console.WriteLine("X = {0:0.000}",-b/a);

        }
        static void Main(string[] args)
        {
            bool flag = true;
            while (true)
            {
               
               switch (Menu())
                {
                   case 1 :
                        Reverse();
                        break;
                   case 2: GetAverage();
                        break;
                   case 3: SolvePolynom();
                        break;
                   case 4:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("you shoud choose a number between 1 and 4 ");
                        break;

                }

               if (flag==false)
               {
                   break;
               }

            }
        }
    }
}
