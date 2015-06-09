using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School1
{
    class TestSchool
    {
        public static void Main()
        {
            Student ivan = new Student("ivan", "ivanov", "1111155555", 15);
            Student gosho = new Student("gosho", "ivanov", "1111155554", 16);
            Student ivanka = new Student("ivanka", "ivanov", "1111155553", 9);
            Student gogo = new Student("gogo", "asenov", "1111155553", 8);
            Console.WriteLine(ivan.ToString());
            Console.WriteLine(gosho.ToString());
            Console.WriteLine(ivanka.ToString());
            Console.WriteLine(gogo.ToString());


            Teacher pesho = new Teacher("pesho", "peshov", "6565656565", 45, new List<Discipline>() { new Discipline("Math", 5, 4), new Discipline("English", 3, 4) });
            Teacher vanq = new Teacher("vanq", "peshova", "6565656563", 40, new List<Discipline>() { new Discipline("Math", 5, 4), new Discipline("Biology", 2, 3) });
            Teacher asen = new Teacher("asen", "peshov", "6535656565", 55, new List<Discipline>() { new Discipline("Geography", 5, 4), new Discipline("English", 3, 4) });
            Teacher stamatka = new Teacher("stamatka", "peshova", "6575656563", 23, new List<Discipline>() { new Discipline("French", 5, 4), new Discipline("Spanish", 2, 3) });
            Console.WriteLine(pesho.ToString());
            Console.WriteLine(vanq.ToString());

            Classes a5 = new Classes(new List<Teacher>() { pesho, asen }, "5A");
            Classes b6 = new Classes(new List<Teacher>() { stamatka, vanq,asen}, "6B");

            School pmgVasilApr = new School(new List<Classes>() { a5, b6 }, "pmgVasilApr");

            Console.WriteLine(pmgVasilApr.ToString());
        }
    }
}
