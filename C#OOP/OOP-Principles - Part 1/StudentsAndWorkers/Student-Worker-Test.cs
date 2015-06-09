using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Student_Worker_Test
    {
        public static void Main()
        {
            List<Student> students = new List<Student>(){new Student ("Ivan","Petrov",5),new Student ("Ivanka","Petrova",6),new Student ("Asq","Ivanova",3),
        new Student ("Gosho","Manolov",4),new Student ("Dan","VAnev",3),new Student ("Ioan","Gogov",4),new Student ("Mila","Petrova",4),
        new Student ("Milan","Vetrov",2),new Student ("Ana","Asenova",6),new Student ("Milena","Milanova",5)};
            var orderedStudents = from st in students
                                  orderby st.Grade descending
                                  select st;
            Console.WriteLine("ordered students: ");
            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ordered workers");
            List<Worker> workers = new List<Worker>() { new Worker("Ivan", "Ivanov", 200, 8, 5), new Worker("Ivanka", "Ivanova", 250, 7, 6) 
             ,new Worker("Petkan", "Petov", 300, 6, 4), new Worker("Lena", "Lenova", 150, 6, 4) ,new Worker("Gosho", "Nanov", 400, 5, 3), new Worker("Asen", "Lilov", 500, 10, 2)
             ,new Worker("Dobri", "Dobrev", 320, 11, 7), new Worker("Dobho", "Manev", 700, 2, 3) ,new Worker("Mila", "Galeva", 100, 3, 3), new Worker("Galina", "Ivanova", 300, 4, 4)};
            var orderedBySalary = from wo in workers
                                  orderby wo.MoneyPerHour() descending
                                  select wo;
            foreach (var worker in orderedBySalary)
            {
                Console.WriteLine(worker.ToString());
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ordered people by first name adn last name");

            List < Human > people = new List<Human>();
            foreach (var st in students)
            {
                people.Add(st);
            }

            foreach (var wo in workers)
            {
                people.Add(wo);
            }

            var orderedPeople = people.OrderBy(p => p.FirstName).ThenBy(p => p.LastName);
            foreach (var person in orderedPeople)
            {
                Console.WriteLine(person.ToString());
            }



        }
    }
}
