using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToBinary
{

    class HexToBin
    {
        static string HexToBinar(string hexaDec)
        {
            char[] hexChar = hexaDec.ToUpper().ToCharArray();
            StringBuilder binStr = new StringBuilder();
            for (int i = 0; i < hexChar.Length; i++)
            {
                switch (hexChar[i])
                {
                    case 'A': binStr.Append(" 1010"); break;
                    case 'B': binStr.Append(" 1011"); break;
                    case 'C': binStr.Append(" 1100"); break;
                    case 'D': binStr.Append(" 1101"); break;
                    case 'E': binStr.Append(" 1110"); break;
                    case 'F': binStr.Append(" 1111"); break;
                    case '0': binStr.Append(" 0000"); break;
                    case '1': binStr.Append(" 0001"); break;
                    case '2': binStr.Append(" 0010"); break;
                    case '3': binStr.Append(" 0011"); break;
                    case '4': binStr.Append(" 0100"); break;
                    case '5': binStr.Append(" 0101"); break;
                    case '6': binStr.Append(" 0110"); break;
                    case '7': binStr.Append(" 0111"); break;
                    case '8': binStr.Append(" 1000"); break;
                    case '9': binStr.Append(" 1001"); break;
                }
            }
            return binStr.ToString();
        }
        static void Main()
        {
            Console.Write(" write your hex number : ");
            string hexaDec = Console.ReadLine();
            Console.WriteLine("your hex number in binary representation is {0} ",HexToBinar(hexaDec));


        }
    }
}
