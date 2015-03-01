/*Problem 6. Quadratic Equation

    Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

 */

using System;


class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("write the coefficients of quadratic equation ax^2 + bx + c = 0");
        Console.Write("write the a coefficient ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("write the b coefficient ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("write the c coefficient ");
        double c = double.Parse(Console.ReadLine());
        double determinanteBeforeSqrt = b * b - 4 * a * c;
        if (determinanteBeforeSqrt >= 0)
        {
            double root1 = (-b - Math.Sqrt(determinanteBeforeSqrt)) / (2 * a);
            double root2 = (-b + Math.Sqrt(determinanteBeforeSqrt)) / (2 * a);
            if (root1 == root2)
            {
                Console.WriteLine("X1=X2={0}", root1);
            }
            else
            {
                Console.WriteLine("the first root X1= {0} , the second X2= {1}", root1, root2);
            }

        }
        else
        {
            Console.WriteLine("No real roots");
        }
        Console.ReadLine();//pause
    }
}

