using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapess.Shapes
{
    abstract class Shape
    {
        private double height;
        private double width;


        public double Height
        {
            get
            {
                return this.height;

            }

            set
            {
                if (value>0)
                {
                    this.height = value;
                }
                else
                {
                    throw new ArgumentException(" height should be positivie ");
                }
            }
        }

        public double Width
        {
            get
            {
                return this.width;

            }

            set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    throw new ArgumentException("width  should be positivie ");
                }
            }
        }
        public Shape(double height, double  width)
        {
            this.Width = width;
            this.Height = height;

        }




        public abstract  double CalculateSurface();
    }
}
