/*Problem 9. Trapezoids

    Write an expression that calculates trapezoid's area by given sides a and b and height h.

 */


using System;


namespace Trapezoids
{
    class Trzapezoids
    {
        static void Main()
        {
            Console.Write("write the a-side of trapezoid ");
            decimal aSide = decimal.Parse(Console.ReadLine());
            Console.Write("write the b-side of trapezoid ");
            decimal bSide = decimal.Parse(Console.ReadLine());
            Console.Write("write the height of trapezoid ");
            decimal height = decimal.Parse(Console.ReadLine());
            decimal result=((aSide+bSide)/2)*height;
            Console.WriteLine("the area is : {0}",result);
            Console.Read();//pause 
        }
    }
}
