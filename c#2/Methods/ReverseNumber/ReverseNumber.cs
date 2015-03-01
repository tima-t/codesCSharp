using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class ReverseNumber
    {
        public static void Reverse()
        {
            bool flag=true;
            Console.Write("write your number: ");
            string number = Console.ReadLine();
            Console.WriteLine("the reversed number is : ");
            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (number[0]=='-'&& flag == true)
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
        static void Main(string[] args)
        {

            Reverse();
        }
    }
}
