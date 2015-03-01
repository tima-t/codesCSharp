/*Problem 7. Point in a Circle

    Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

Examples:
 */


using System;


namespace PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            int radius = 2; //  given  in the task 
            Console.WriteLine("we have a circle k {0,0},2");
            Console.Write("write x cordinate : ");
            double xCordinate = double.Parse(Console.ReadLine());
            Console.Write("write y cordinate : ");
            double yCordinate = double.Parse(Console.ReadLine());
            bool isTheGivenPointIn = ((xCordinate * xCordinate + yCordinate * yCordinate) <= radius * radius);//Chek if the point is in the cyrcle
            Console.WriteLine("The given point ({0};{1}) is in the cyrcle: {2}",xCordinate,yCordinate,isTheGivenPointIn);
            Console.Read();//pause 
        }
    }
}
