using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Shapess.Shapes;

namespace Shapess
{
    class ShapesTest
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Square(5));
            shapes.Add(new Square(7));
            shapes.Add(new Rectangle(5,4));
            shapes.Add(new Triangle(5,2));
            foreach (var figure in shapes)
            {
                Console.WriteLine("the shape of the figure is {0}", figure.CalculateSurface());
            }
        }

        
    }
}
