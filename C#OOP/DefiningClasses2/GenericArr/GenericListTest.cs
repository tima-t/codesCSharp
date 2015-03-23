using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArr
{
    class GenericListTest
    {
       static void Main()
       {
           GenericList<int> array = new GenericList<int>(4);
           Console.Write("capacity : ");
           Console.WriteLine(array.Capacity);

           Console.Write("count: ");
           Console.WriteLine(array.Count);
           for (int i = 0; i < 6; i++)
           {
               array.AddEl(i);
           }


           Console.WriteLine("///////////");
           Console.Write("capacity : ");
           Console.WriteLine(array.Capacity);

           Console.Write("count: ");
           Console.WriteLine(array.Count);
           Console.WriteLine(array.ToString());
           Console.WriteLine("max = {0} ", array.Max());
          Console.WriteLine("min = {0} ", array.Min());
           array.InsertEl(6, -4);
           array.InsertEl(7, -55);
           Console.WriteLine(array.ToString());
           Console.WriteLine("max = {0} ", array.Max());
           Console.WriteLine("min = {0} ", array.Min());
           Console.WriteLine("The index of 3 is {0}", array.ReturnIndex(3));
           array.ClearList();
           Console.Write("capacity : ");
           Console.WriteLine(array.Capacity);
           Console.Write("count: ");
           Console.WriteLine(array.Count);
           Console.WriteLine(array.ToString());
       
           // now we will try with string list //
           ///////////////////////////////////////
           ////////////////////////////////////////
           ///////////////////////////////////////
           GenericList<string> array1 = new GenericList<string>(4);
           Console.Write("capacity : ");
           Console.WriteLine(array1.Capacity);

           Console.Write("count: ");
           Console.WriteLine(array1.Count);
           for (int i = 0; i < 6; i++)
           {
               array1.AddEl("C#"+i);
           }


           Console.WriteLine("///////////");
           Console.Write("capacity : ");
           Console.WriteLine(array1.Capacity);

           Console.Write("count: ");
           Console.WriteLine(array1.Count);
           Console.WriteLine(array1.ToString());
           Console.WriteLine("max = {0} ", array1.Max());
          Console.WriteLine("min = {0} ", array1.Min());
           array1.InsertEl(6, "hi");
           array1.InsertEl(7, "add");
           Console.WriteLine(array1.ToString());
           Console.WriteLine("max = {0} ", array1.Max());
          Console.WriteLine("min = {0} ", array1.Min());
           Console.WriteLine("The index of C#1 is {0}", array1.ReturnIndex("C#1"));
           array1.ClearList();
           Console.Write("capacity : ");
           Console.WriteLine(array1.Capacity);
           Console.Write("count: ");
           Console.WriteLine(array1.Count);
           Console.WriteLine(array1.ToString());

           



       }
    }
}
