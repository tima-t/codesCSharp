using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School1
{
    class Teacher:People
    {
        private  List<Discipline> disciplines;
       public  List<Discipline> Disciplines { get; set; }
       public Teacher(string fname, string lname, string egn, int age, List<Discipline> disciplines)
            : base(fname, lname, egn, age)
        {
            if (this.Age<20 || this.Age>85)
            {
                throw new ArgumentException("you are not a teacher");
            }
            this.disciplines = disciplines;
        }

       public override string ToString()
       {
           var dispnames = from disp in disciplines
                          select disp.Name;
           return this.Fname + " " + this.LName + " " + this.Egn + " " + this.Age + " " + String.Join(",", dispnames);
       }
    }
}
