using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure3d
{
    class _3dPointTest
    {
        public static void Main()
        {
            Point3d point = new Point3d();
            point.X = 5.5;
            point.Y = 5.4;
            point.Z = 2;
            Console.WriteLine(point.ToString());
            var point1 = new Point3d(2, 3, 4);
            Console.WriteLine(point1.ToString());
            Console.WriteLine(Point3d.O.ToString());

            // paths of points test 
            Path path = new Path();
            path.AddPoint(point);
            path.AddPoint(point1);
            PathStorage.SavePaths(path, "Path");
            Console.WriteLine( "Loading from file .....   \n" + PathStorage.LoadPaths("..//..//Path.txt").ToString());
        }
    }
}
