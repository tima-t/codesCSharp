using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School1
{
    abstract class People 
    {
       public  string Fname { get; set; }
       public string LName { get; set; }

       private string egn;

       public string Egn
       {
           get { return this.egn; }
           set
           {
               if (value.Length!=10)
               {
                   throw new ArgumentException(" invalid egn ");
               }

            foreach (var symb in value)
               {
                   if (symb<'0' || symb>'9')
                   {
                       throw new ArgumentException(" invalid egn ");
                   }
                   
               }
               this.egn = value;
           }
       }
       public  int Age { get; set; }

       public People(string fname, string lname, string egn, int age)
       {
           this.Fname = fname;
           this.LName = lname;
           this.Age = age;
           this.Egn = egn;
       }

    }
}
