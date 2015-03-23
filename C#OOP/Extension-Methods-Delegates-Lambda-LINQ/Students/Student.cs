using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Student
    {
       
        public string FirstName { get; set; }
        public  string LastName { get; set; }

        private int age;
        public int Age
        {
            get
            {
                return this.age;

            }
            set
            {
                if (value > 6 && value < 70)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid age ");
                }

            }
        }
            

        public Student(string fName, string lName, int age )
        {
           this.FirstName = fName;
           this.LastName = lName;
           this.Age = age;

        }

        public override string ToString()
        {
            return this.FirstName +" " + this.LastName;
        }

        public static void Main()
        {
            List<Student> students = new List<Student>() { new Student("Ivan", "Georgiev", 15), new Student("Asen", "Popov", 19), new Student("Gospodin", "Asenov", 23), new Student("Gospodin", "Milenov", 28), new Student("Bojo", "Todorov", 14), new Student("Ivan", "Asenov", 23) };
            var FirstBefLast = from st in students
                               where st.FirstName.CompareTo(st.LastName) < 0
                               select st;
            Console.WriteLine("Order by firs before last name");
            foreach (var st in FirstBefLast)
            {
               
                Console.WriteLine(st.ToString());
            }

            var AgeRange = from st in students
                           where (st.Age >= 18 && st.Age <= 24)
                           select st;
            Console.WriteLine("age between 18 and 24 ");
            foreach (var st in AgeRange)
            {
                Console.WriteLine(st.ToString());
            }

            var FirstLastDescending = students.OrderByDescending(st => st.FirstName).
                ThenByDescending(st => st.LastName).ToList();
            Console.WriteLine("order by first and last name in descending ");
            foreach (var st in FirstLastDescending)
            {
                Console.WriteLine(st);
            }
                
               
        }

       
    }
}
