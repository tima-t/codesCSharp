using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentUpg
{
    class TestStudentUpgr
    {
        public static void Main()
        {
            List<StudentUpg> studentList = new List<StudentUpg>();
            studentList.Add(new StudentUpg("Ivan", "Georg", "00000678", "0275644", "ivang@gmail", new List<int>() { 2, 3, }, 43));
            studentList.Add(new StudentUpg("Ivan", "Georgiev", "00000578", "077564412", "ivanger@gmail", new List<int>() { 2, 3, 3, 3, 5, 4, 6, 2, 5, 4, }, 42));
            studentList.Add(new StudentUpg("Pepa", "Alenova", "00006678", "024575644", "pepg@abv.bg", new List<int>() { 2, 2, 5, 3, 5, 4, 5, 2, 3, 4, }, 55));
            studentList.Add(new StudentUpg("Hinko", "Hinev", "00005678", "86775644", "hinko@gmail", new List<int>() { 2, 3, 6, 5, 6, 4, 6, 2, 5, 4, }, 43));
            studentList.Add(new StudentUpg("Ivan", "Gogov", "00021678", "0775644", "ivangogo@gmail", new List<int>() { 2, 2, 4, 5, 2, 4, 2, 2, 5, 4, }, 43));
            studentList.Add(new StudentUpg("Mishoka", "Kolev", "00005678", "032775644", "ivang@gmail", new List<int>() { 5, 6, }, 53));
            studentList.Add(new StudentUpg("Iva", "Giga", "00004678", "0775644", "ivai@gmail", new List<int>() { 2, 3, 4, 5, 3, 4, 6, 2, 3, 4, }, 47));
            studentList.Add(new StudentUpg("Mima", "lilova", "00000678", "0275644", "mim@abv.bg", new List<int>() { 2, 2, 4, 2, 5, 4, 3, 2, 5, 4, }, 53));
            studentList.Add(new StudentUpg("Asq", "lilovavona", "00032678", "0975644", "lim@abv.bg", new List<int>() { 3, 5, 4, 6, 6, 4, 6, 2, 5, 4, }, 53));
            var studentsByName = from st in studentList

                                 orderby st.FirstName
                                 select st;
            foreach (var student in studentsByName)
            {
                Console.WriteLine(student.ToString());
            }

            var studentsByName2 = studentList.OrderBy(st => st.FirstName);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("other way ");
            foreach (var student in studentsByName2)
            {
                Console.WriteLine(student.ToString());
            }

            var abvEmails = from st in studentList
                            where st.Email.Contains("abv.bg")
                            select st;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("containing abv :  ");
            foreach (var student in abvEmails)
            {
                Console.WriteLine(student.ToString());
            }

            var phonesInSofia = from st in studentList
                                where st.PhoneNumber.StartsWith("02")
                                select st;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("sofia phones :  ");
            foreach (var student in phonesInSofia)
            {
                Console.WriteLine(student.ToString());
            }
            //////////////////////////

            var studentsWithExcellentMark =
          from st in studentList
          where st.Marks.Contains(6)
          select new
          {
              FullName = st.FirstName + " " + st.LastName,
              MarksList = st.Marks
          };

            Console.WriteLine("Students that have at least one excellent mark, each in new anonymous class with " +
                              "properties Fullname and MarksList:\n");

            foreach (var student in studentsWithExcellentMark)
            {
                Console.WriteLine("Full name: {0}", student.FullName);
                Console.WriteLine("Marks: {0}", string.Join(", ", student.MarksList));
                Console.WriteLine();
            }

            var TwoMarks = from st in studentList
                           where st.Marks.Count == 2
                           select st;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("two marks :  ");
            foreach (var student in
                TwoMarks)
            {
                Console.WriteLine(student.ToString());
            }
            var stud06 = from st in studentList
                         where (st.FN[4] == '0' && st.FN[5] == '6')
                         select st;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("student from 2006 :  ");
            foreach (var student in
                stud06)
            {
                Console.WriteLine(student.ToString());
            }

            // task with strings 17 will eb introduced here 

            var stringLenght = studentList.OrderBy(st => st.FirstName.Length).ThenBy(st => st.LastName.Length);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("the longest first name is  :  ");
            Console.WriteLine(stringLenght.Last().FirstName);
              

         
            










            /////////////////////////////////////////////
            var studGroups = from st in studentList
                             orderby st.GroupNumber descending
                             group st by st.GroupNumber;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("student in groups descending  :  ");

            foreach (var stgrup in studGroups)
            {
                foreach (var st in stgrup)
                {
                    Console.WriteLine(st);
                }
            }

            var studGroups1 = studentList.OrderBy(st=>st.GroupNumber).GroupBy(st => st.GroupNumber);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("student in groups  other way not descending :  ");

            foreach (var stgrup in studGroups1)
            {
                foreach (var st in stgrup)
                {
                    Console.WriteLine(st);
                }
            }

        }
    }
}
