using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
  abstract  class Human
    {
       public string FirstName{get;set;}
       public string LastName { get; set; }

       public Human(string fName, string lName)
       {
           this.FirstName = fName;
           this.LastName = lName;
       }

    }
}
