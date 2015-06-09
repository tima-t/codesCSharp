using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*We are given a school. In the school there are classes of students. Each class has a set of teachers. Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.

 */
namespace School1
{
    class School
    {
        
        public List<Classes> ClassesS { get; set; }
        public string Name { get; set; }

        public School(List<Classes> classes, string name)
        {
            this.ClassesS = classes;
            this.Name = name;
        }

        public override string ToString()
        {
            var classesNames= from cl in ClassesS
                              select cl.Idetifier;
            return this.Name + "    " + String.Join(",", classesNames);
        }

    }
}
