using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class StudentTest
    {
        public static void Main()
        {
            Student petko = new Student("petko", "goshov", "petrov", "ul nezavismost", "petko.com", "111222333", 2, Specialities.IT, University.TU, Faculties.InformFac);
            Student goshko1 = new Student("goshko", "goshov", "goshov", "ul nezavismost15", "goshko.com", "1112223331", 2, Specialities.QA, University.SofiaUniv, Faculties.InformFac);
            Student petko2 =(Student) petko.Clone();
            Console.WriteLine(petko);
            Console.WriteLine(goshko1);
            Console.WriteLine("petko compare to goshko : {0}",petko.CompareTo(goshko1));
            Console.WriteLine("petko compare to petko 2  : {0}", petko.CompareTo(petko2));
            Console.WriteLine("petko compare to goshko with equals  : {0}", petko.Equals(goshko1));
            Console.WriteLine(petko2.ToString());
            Console.WriteLine(petko.GetHashCode());


        }
    }
}
