/*Problem 11. Bitwise: Extract Bit #3

    Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
    The bits are counted from right to left, starting from bit #0.
    The result of the expression should be either 1 or 0.

 */


using System;


namespace ExtractBit3
{
    class ExtractBit3
    {
        static void Main()
        {
            Console.Write("write your number ");
            uint number = uint.Parse(Console.ReadLine());
            string binary = "0000000";// we add 0000000 in the begging of the binary number  because this dont change the result and we wont get out of bounds
            binary =  binary + Convert.ToString(number, 2);// we add 0000 and the concatenate it with  our number in binary code 
            Console.WriteLine("The #3-rd bit from right to left starting from #0bit is  {0}", binary[binary.Length - 4]);// because binary.lenght-1 is the last element and binary.lenght-4 is the searched bit 
            Console.ReadKey(); //pause
        }
    }
}
