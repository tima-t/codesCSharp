using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School1
{
    class Student : People
    {
        private int classNumber;

        private static int LastclassN;
        public int ClassNumber { get;  private set; }

        public Student(string fname, string lname, string egn, int age)
            : base(fname, lname, egn, age)
        {
            if (this.Age<6 || this.Age>20)
            {
                throw new ArgumentException("you are not a student");
            }
            this.classNumber = LastclassN++;
            
        }
        public override string ToString()
        {
            return this.Fname + " " + this.LName + " " + this.Egn + " " + this.Age + " " + this.classNumber;
        }
    }
}
