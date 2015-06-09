using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School1
{
    class Discipline  
    {
        public string Name { get; set; }
        public int NumberOfLectures { get; set; }

        public int NumberOfExer { get; set; }


        public Discipline(string name, int numberOfLec, int numberOfExer)
        {
            this.Name = name;
            this.NumberOfExer = numberOfExer;
            this.NumberOfLectures = numberOfLec;
        }

    }
}
