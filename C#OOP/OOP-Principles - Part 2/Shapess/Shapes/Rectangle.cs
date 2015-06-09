﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapess.Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(double height, double width)
            : base(height, width)
        {

        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
