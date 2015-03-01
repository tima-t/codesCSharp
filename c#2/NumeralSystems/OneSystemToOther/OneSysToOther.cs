using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneSystemToOther
{
    class OneSysToOther
    {
        class ConvertFromAnyNumSystem
        {
            static void ConvertFromDec(int number, byte baseTo)
            {
                List<int> result = new List<int>();
                if (baseTo > 10)
                {
                    while (number > 0)
                    {
                        result.Add(number % baseTo);
                        number = number / baseTo;
                    }
                    result.Reverse();
                    foreach (var item in result)
                    {
                        switch (item)
                        {
                            case 10: Console.Write('A'); break;
                            case 11: Console.Write('B'); break;
                            case 12: Console.Write('C'); break;
                            case 13: Console.Write('D'); break;
                            case 14: Console.Write('E'); break;
                            case 15: Console.Write('F'); break;
                            default: Console.Write(item); break;
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    while (number > 0)
                    {
                        result.Add(number % baseTo);
                        number = number / baseTo;
                    }
                    result.Reverse();
                    foreach (var item in result)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine();
                }
            }

            static int ConvertToDec(string number, byte baseFrom)
            {
                int decNum = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] > '9')
                    {
                        decNum += (number[i] - '7') * (int)Math.Pow(baseFrom, (number.Length - 1 - i));
                    }
                    else
                    {
                        decNum += (number[i] - '0') * (int)Math.Pow(baseFrom, (number.Length - 1 - i));
                    }
                }
                return decNum;
            }
            static void Main()
            {
                Console.Write("write your number: ");
                string number = Console.ReadLine();
                Console.WriteLine("write the base betweeen 2 and 16 ");
                byte b = byte.Parse(Console.ReadLine());
                if (b < 2 || b > 16)
                {
                    Console.WriteLine("wrong input base ");
                    return;
                }

                Console.Write("write the second Base in which you want your number : ");
                byte b2 = byte.Parse(Console.ReadLine());
                if (b < 2 || b > 16)
                {
                    Console.WriteLine("wrong input base ");
                    return;
                }
                ConvertFromDec(ConvertToDec(number, b), b2);



                Console.WriteLine();


            }
        }
    }
}
