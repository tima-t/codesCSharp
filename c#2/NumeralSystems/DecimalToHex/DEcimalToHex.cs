using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHex
{
    class DEcimalToHex
    {
        public static string Reverse(string text)
        {
            if (text == null) return null;

            // this was posted by petebob as well 
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
        static void Main()
        {
            Console.Write("write your decimal  number: ");
            long number = long.Parse(Console.ReadLine());
            long numberHolder = number;
            int[] array = new int[50];
            int counter = 0;
            string hex = "";



            while (number != 0)
            {


                array[counter] = (int)(number % 16);
                number /= 16;
                switch (array[counter])
                {
                    case 0:
                        hex += '0';
                        break;
                    case 1:
                        hex += '1';
                        break;
                    case 2:
                        hex += '2';
                        break;
                    case 3:
                        hex += '3';
                        break;
                    case 4:
                        hex += '4';
                        break;
                    case 5:
                        hex += '5';
                        break;
                    case 6:
                        hex += '6';
                        break;
                    case 7:
                        hex += '7';
                        break;
                    case 8:
                        hex += '8';
                        break;
                    case 9:
                        hex += '9';
                        break;
                    case 10:
                        hex += 'A';
                        break;
                    case 11:
                        hex += 'B';
                        break;
                    case 12:
                        hex += 'C';
                        break;
                    case 13:
                        hex += 'D';
                        break;
                    case 14:
                        hex += 'E';
                        break;
                    case 15:
                        hex += 'F';
                        break;
                    default:
                        Console.WriteLine("something get wrong...");
                        break;
                }


                ++counter;
            }

            Console.WriteLine("your number {0} in hexadecima is {1} ", numberHolder, Reverse(hex));
        }
    }
}
