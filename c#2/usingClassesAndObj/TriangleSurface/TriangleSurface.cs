using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurface
{
    class TriangleSurface
    {
        public static double FindAreaBYAttitude()
        {
            Console.Write("write the side of the triangle: ");
            double side =double.Parse(Console.ReadLine());
            Console.Write("write the attitude of the triangle: ");
            double attitude = double.Parse(Console.ReadLine());
            double area = (side * attitude) / 2;
            return area;


        }

        public static double AreaByHeronFormula()
        {
            Console.Write("write the side 1  of the triangle: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("write the side 2 of the triangle: ");
            double side2 = double.Parse(Console.ReadLine());
            Console.Write("write the side 3  of the triangle: ");
            double side3 = double.Parse(Console.ReadLine());
            double halfPerimeter = 0.5 * (side1 + side2 + side3);
            double area = Math.Sqrt((halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3)));
            return area;

        }
        public static double AreaByTwoSidesAndAngle()
        {
            Console.Write("write the side 1  of the triangle: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("write the side 2 of the triangle: ");
            double side2 = double.Parse(Console.ReadLine());
            Console.Write("write the angle betwwen the sides of the triangle: ");
            double angle = double.Parse(Console.ReadLine());
             angle =  angle * Math.PI / 180;
            double area = side1 * side2 * Math.Sin(angle) / 2;
            return area;


        }
        public static void Menu()
        {
            Console.WriteLine("//////////////////////////////// make your choise and write number between 1 and 4 ////////////////////////");
            Console.WriteLine("1 Find area by side and attitude ");
            Console.WriteLine("2 Find area by Heron Formula");
            Console.WriteLine("3 Find area by two sides and an angel between them ");
            Console.WriteLine("4 Exit the menu ");
            Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////////////////");
        }

        static void Main()
        {
            while (true)
            {
               
                Menu();
                byte choice;
                bool isParsed=byte.TryParse(Console.ReadLine(), out choice);
                
                switch (choice)
                {
                    case 1: Console.WriteLine("The area is {0}",FindAreaBYAttitude());
                        break;
                    case 2: Console.WriteLine("The area is {0}", AreaByHeronFormula());
                        break;
                    case 3: Console.WriteLine("The area is {0}", AreaByTwoSidesAndAngle());
                        break;
                    case 4: Console.WriteLine("Good Bye");
                        return;


                    default: Console.WriteLine("Try Again ");
                        break;
                }
            }

        }
    }
}
