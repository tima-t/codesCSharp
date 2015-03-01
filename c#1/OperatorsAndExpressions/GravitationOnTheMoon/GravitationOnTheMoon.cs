/*

 Problem 2. Gravitation on the Moon

    The gravitational field of the Moon is approximately 17% of that on the Earth.
    Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

 
 */


using System;


namespace GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.WriteLine("write your weight on the Earth");
            decimal weightEarh = decimal.Parse(Console.ReadLine());
            Console.WriteLine("your weight on the Moon would be : {0} kilos",(weightEarh*0.17m));// calculate the weight on the moon and write it on the console
            Console.ReadKey(); // pause


        }
    }
}
