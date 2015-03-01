/*Problem 10. Point Inside a Circle & Outside of a Rectangle

    Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

 */

using System;


namespace PointInsideCyrcleOutsideRectangle
{
    class PointInsideCyrcleOutsideRectangle
    {
        static void Main()
        {
            double radius = 1.5; //  given  in the task 
            Console.WriteLine("we have a circle k {0,0},2 and rectangle R(top=1, left=-1, width=6, height=2) ");
            Console.Write("write x cordinate : ");
            double xCordinate = double.Parse(Console.ReadLine());
            Console.Write("write y cordinate : ");
            double yCordinate = double.Parse(Console.ReadLine());
            bool isTheGivenPointInCyrcle = (((xCordinate-1) * (xCordinate-1) + (yCordinate-1) * (yCordinate-1)) <= radius * radius);//Chek if the point is in the cyrcle
            bool isTheGivenPointOutOfRect = ((xCordinate < -1 || xCordinate > 5 || yCordinate > 1 || yCordinate < -1));
            Console.WriteLine("The given point ({0};{1}) is in the cyrcle and out of rectangle: {2}", xCordinate, yCordinate, (isTheGivenPointInCyrcle && isTheGivenPointOutOfRect));
            Console.Read();//pause 
        }
    }
}
