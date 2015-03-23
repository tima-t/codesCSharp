using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure3d
{
    class Path
    {
     private  List<Point3d> pointArray = new List<Point3d>();

     public Path()
     {

     }
       public Path(List<Point3d> pointArray)
       {
           this.pointArray = pointArray;
       }

       public List<Point3d> PointArray {
           get {
               return this.pointArray;
           }
           set
           {
               this.pointArray = value;
               ;
           }
       }

       public void AddPoint(Point3d point)
       {
           this.PointArray.Add(point);
       }

       public void RemovePoint(Point3d point)
       {
           this.PointArray.Remove(point);
       }
       public override string ToString()
       {
           string result = String.Join("\n",this.PointArray);
           return result;
       }


    }
}
