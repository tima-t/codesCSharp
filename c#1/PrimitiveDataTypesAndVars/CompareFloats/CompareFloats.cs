/*Problem 13.* Comparing Floats

    Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.*/


using System;


namespace CompareFloats
{
    class CompareFloats
    {
        static void Main()
        {
            float first;
            float second;
            Console.WriteLine("input your float numbers");
            first = float.Parse(Console.ReadLine());
            second = float.Parse(Console.ReadLine());
            if (first == second)// if the int parts of the numbers are equal we go in this if statement
            {
                long var1 = (long)(first * 1000000);// we multiple the numbers by 10^6 and make them long ints
                long var2 = (long)(second * 1000000);
                if (var1 == var2) { Console.WriteLine("the two numbers are equal"); } // then we compare them again  
                else { Console.WriteLine("the numbers are not equal"); }
            }
            else { Console.WriteLine("the numbers are not equal"); }
            Console.Read(); //pause
        }
    }
}
