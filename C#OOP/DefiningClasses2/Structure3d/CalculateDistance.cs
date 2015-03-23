using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure3d
{
   static  class CalculateDistance
    {
       public static double CalcDist(Point3d point1, Point3d point2)
       {
          double deltaX = point1.X - point2.X;
          double deltaY =point1.Y - point2.Y;
          double deltaZ = point1.Z - point2.Z;

          double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
          return distance;
       }

    
    }
}
