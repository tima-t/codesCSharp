using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School1
{
    class Classes
    {
      public   List<Teacher> Teachers { get; set; }
      public string Idetifier { get; set; }

      public Classes(List<Teacher> teachers, string identifier)
      {
          this.Teachers = teachers;
          this.Idetifier = identifier;
      }
    }
}
