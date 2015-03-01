/*Problem 14. Modify a Bit at Given Position

    We are given an integer number n, a bit value v (v=0 or 1) and a position p.
    Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

 */

using System;


namespace ModifyABitFromGivenPosition
{
    class ModifyABitFromGivenPosition
    {
        static void Main()
        {
            Console.Write("write your number ");
            uint number = uint.Parse(Console.ReadLine());
            Console.Write("write the  number of index of bit you want  ");
            int indexOfBit = byte.Parse(Console.ReadLine());
            Console.Write("write the  value of the  of bit  1 or 0   ");
            char value = char.Parse(Console.ReadLine());
            if (value == '0' || value == '1')
            {
                string binary = "00000000000000";// we add 00000000000 in the begging of the binary number  because this dont change the result and we wont get out of bounds
                binary = binary + Convert.ToString(number, 2);// we add 0000 and the concatenate it with  our number in binary code 
                char[] newBinary = new char[binary.Length];
                string newBinaryFinal = "0";
                for (int i = 0; i < binary.Length; i++)
                {
                    if (i ==(binary.Length- (indexOfBit+1)))
                    {
                        newBinary[i] = value;
                        newBinaryFinal = newBinaryFinal + newBinary[i];
                    }
                    else
                    {
                        newBinary[i] = binary[i];
                        newBinaryFinal = newBinaryFinal + newBinary[i];
                    }
                    
                }
                long newNumber = Convert.ToInt64(newBinaryFinal, 2);
                Console.WriteLine("The  binary result is {0} the new number is  {1}", newBinaryFinal, newNumber);
            }
            else
            {
                Console.WriteLine("wrong input ");
            }
            Console.Read();//pause
        }
    }
}
