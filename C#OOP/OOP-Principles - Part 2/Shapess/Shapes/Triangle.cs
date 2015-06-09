using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapess.Shapes
{
    class Triangle : Shape
    {
        public Triangle(double height, double side)
            : base(height, side)
        {

        }

        public  override double CalculateSurface()
        {
            return (this.Height * this.Width) / 2;
        }

    }
}
