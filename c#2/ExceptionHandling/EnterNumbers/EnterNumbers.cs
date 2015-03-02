using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EnterNumbers
{
    static int Max = 100;
    
    static int ReadNumber(int begin, int finish)
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        if ((number < begin) || (number > finish))
        {
            throw new Exception("Invalid range entered");
        }
        return number;
    }
    static void Main()
    {
       
        Console.WriteLine("write your numbers in increasing order , please !");
        int[] numbers = new int[10];
        int min = 1;
      
        try
        {
            numbers[0] = ReadNumber(min, Max);
            for (int i = 1; i < numbers.Length; i++)
            {
                min = numbers[i - 1];
                numbers[i] = ReadNumber(min, Max);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}