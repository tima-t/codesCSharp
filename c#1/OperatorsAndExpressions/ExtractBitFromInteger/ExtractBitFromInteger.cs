/*Problem 12. Extract Bit from Integer

    Write an expression that extracts from given integer n the value of given bit at index p.

Examples:
 */



using System;


namespace ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.Write("write your number ");
            uint number = uint.Parse(Console.ReadLine());
            Console.Write("write the  number of index of bit you want  ");
            byte indexOfBit = byte.Parse(Console.ReadLine());
            string binary = "00000000000000";// we add 00000000000 in the begging of the binary number  because this dont change the result and we wont get out of bounds
            binary = binary + Convert.ToString(number, 2);// we add 0000 and the concatenate it with  our number in binary code 
            Console.WriteLine("The {0} bit from right to left starting from #0bit is  {1}",indexOfBit, binary[binary.Length - (indexOfBit+1)]);// because binary.lenght-1 is the last element and binary.lenght-(indexOfBit+1) is the searched bit 
            Console.ReadKey(); //pause
            

        }
    }
}
