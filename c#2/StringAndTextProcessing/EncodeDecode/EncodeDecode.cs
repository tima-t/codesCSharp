using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeDecode
{
    class EncodeDecode
    {
        static void Main()
        {
            Console.Write("Enter a secret messad: ");
            string input = Console.ReadLine();
            Console.Write("Enter the  cipher : ");
            string cipher = Console.ReadLine();
            string encoded = EncodeDecoded(input, cipher);
            string decoded = EncodeDecoded(encoded, cipher);
            Console.WriteLine(encoded);
            Console.WriteLine(decoded);
        }
        private static string EncodeDecoded(string input, string cipher)
        {
            StringBuilder result = new StringBuilder();
            int inputLetter;
            int cipherLetter;
            for (int current = 0; current < input.Length; current++)
            {
                inputLetter = (int)input[current];
                cipherLetter = (int)cipher[current % cipher.Length];
                result.Append((char)(inputLetter ^ cipherLetter));
            }
            return result.ToString();
        }
    }

}


