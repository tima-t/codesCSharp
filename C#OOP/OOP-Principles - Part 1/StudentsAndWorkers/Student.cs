using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Student:Human
    {
        private byte grade;
        public byte Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                if (value<2 || value >6)
                {
                    throw new ArgumentOutOfRangeException("invalid grade");
                }
                this.grade = value;
            }
           
        }
        public Student(string fName, string lName, byte grade)
            : base(fName, lName)
        {
            this.Grade = grade;
        }
        public override string ToString()
        {
            return this.FirstName + "  " + this.LastName + "  " + this.Grade;
        }
    }
}
