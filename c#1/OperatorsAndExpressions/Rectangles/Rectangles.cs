/*Problem 4. Rectangles

    Write an expression that calculates rectangle’s perimeter and area by given width and height.


 */

using System;

namespace Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write the width of rectangle");
            decimal width = decimal.Parse(Console.ReadLine());
            Console.WriteLine("write the height of recangle");
            decimal height = decimal.Parse(Console.ReadLine());
            Console.WriteLine("the perimeter is : {0}",(2*width+2*height));
            Console.WriteLine("the area is : {0}", (width*height));
            Console.ReadLine();//pause

        }
    }
}
