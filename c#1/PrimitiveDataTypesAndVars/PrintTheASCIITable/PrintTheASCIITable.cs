/*Problem 14.* Print the ASCII Table

    Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
*/


using System;


namespace PrintTheASCIITable
{
    class PrintTheASCIITable
    {
        static void Main(string[] args)
        {
            char counter;
            for (int i = 0; i < 255; i++)
            {
                counter =(char) i;
                Console.WriteLine("the number {0}  the symbol {1}", i,counter);
                
            }
            Console.Read(); //pause
        }
    }
}
