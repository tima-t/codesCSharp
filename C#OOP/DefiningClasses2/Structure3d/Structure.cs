using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure3d
{
 
    public struct Point3d
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        private static readonly Point3d o = new Point3d(0, 0, 0);
        public static Point3d O { get; private set; }
        public Point3d(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }





        public override string ToString()
        {
            string result = "x= " + this.X + "  y= " + this.Y + "  z= " + this.Z;
            return result;
        }

        public static Point3d Parse(string input) //method for parsing the 3dPoints from the saved txt file
        {
            StringBuilder coordinates = new StringBuilder();
            double[] xyz = new double[3];
            int xyzIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]) || input[i] == '-')
                {
                    while (i < input.Length && (Char.IsDigit(input[i]) || input[i] == '-' || input[i] == '.'))
                    {
                        coordinates.Append(input[i]);
                        i++;
                    }
                }

                if (coordinates.Length > 0)
                {
                    double coord = double.Parse(coordinates.ToString());
                    xyz[xyzIndex] = coord;
                    xyzIndex++;
                    coordinates.Clear();
                }
            }

            return new Point3d(xyz[0], xyz[1], xyz[2]);
        }
    }
}

