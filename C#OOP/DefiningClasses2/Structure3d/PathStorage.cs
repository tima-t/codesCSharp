using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Structure3d
{
   static class PathStorage
    {
       public static Path LoadPaths(string filePath)
       {
           Path path = new Path();

           using (StreamReader sr = new StreamReader(filePath))
           {
               while (sr.EndOfStream == false)
               {
                   string nextPointTxt = sr.ReadLine();
                   Point3d nextPoint = Point3d.Parse(nextPointTxt);
                   path.AddPoint(nextPoint);
               }
           }

           return path;
       }

       public static void SavePaths(Path path,string pathName)
       {
           using (StreamWriter sw = new StreamWriter("..//..//" + pathName + ".txt"))
           {
               for (int i = 0; i < path.PointArray.Count; i++)
               {
                   sw.WriteLine(path.PointArray[i]);
               }
           }
       }
    }
}
