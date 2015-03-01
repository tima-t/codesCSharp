/*Problem 3. Circle Perimeter and Area

    Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

 */



using System;


    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("Write the radius of the circle r= ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("the perimeter of the circle is {0:0.00}",radius*2*Math.PI);
            Console.WriteLine("the area of the circle is {0:0.00}",radius*radius*Math.PI);
            Console.ReadLine();//pause
        }
    }

