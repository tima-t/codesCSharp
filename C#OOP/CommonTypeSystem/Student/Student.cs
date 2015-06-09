using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public enum Specialities
    {
        Informatics = 1,
        Math = 2,
        IT = 3,
        QA = 4
    }

    public enum University
    {
        TU = 1,
        SofiaUniv = 2,
        NewBulgarianUniv = 3,
        UNV = 4

    }

    public enum Faculties
    {
        MathFa = 1,
        InformFac = 2,
        PhylosophyFac = 3
    }

    class Student : ICloneable,IComparable<Student>
    {
        public string FName { get; private set; }
        public string MName { get; private set; }
        public string LName { get; private set; }

        public int Ssn { get; set; }

        private static int currentSsn;

        public string Address { get; private set; }

        public string MobPhone { get; private set; }

        public string Email { get; private set; }

        public byte Course { get; set; }
        public Specialities Speciality { get; set; }

        public University Univ { get; private set; }

        public Faculties Faculty { get; private set; }

        public Student(string fName, string mName, string lName, string address, string email, string mobPhone, byte course, Specialities spec, University univ, Faculties fac)
        {
            this.FName = fName;
            this.MName = mName;
            this.LName = lName;
            this.Ssn = ++currentSsn;
            this.Address = address;
            this.Email = email;
            this.MobPhone = mobPhone;
            this.Course = course;
            this.Speciality = spec;
            this.Univ = univ;
            this.Faculty = fac;

        }

        public Student()
        {
      
        }

        public override bool Equals(object param)
        {
            // If the cast is invalid, the result will be null
            Student student = param as Student;

            // Check if we have valid not null Student object
            if (student == null)
            {
                return false;
            }

            // Compare the reference type member fields
            if (this.FName.Equals(student.FName) && this.LName.Equals(student.LName) && (this.Ssn).Equals(student.Ssn))// this is  enough because the ssn is unique auto increment (you can change it only true the stter)
            // and is ssn is equal we have the same student two times
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override int GetHashCode()
        {
            return this.FName.GetHashCode() ^ this.Email.GetHashCode();
        }

        public override string ToString()
        {
            string result = this.FName +"  " + 
             this.MName + "  " +
                        this.LName + "  " +
                           this.Ssn + "  " +
                           this.Address + "  " +
                           this.Email + "  " +
                      this.MobPhone + "  " +
                           this.Course + "  " +
                         this.Speciality + "  " +
                           this.Univ + "  " +
                           this.Faculty;

            return result;

        }

        public object Clone() // deep clone
        {
            Student st = new Student();
            st.FName = string.Copy(this.FName);
            st.LName =string.Copy(this.LName);
            st.MName = string.Copy(this.MName);
            st.Ssn = this.Ssn;
            st.MobPhone = string.Copy(this.MobPhone);
            st.Speciality = this.Speciality;
            st.Univ = this.Univ;
            st.Course = this.Course;
            st.Address = string.Copy(this.Address);
            st.Faculty = this.Faculty;
            st.Email = string.Copy(this.Email);
            return st;
        }

      
                  public int CompareTo(Student stud)
        {
            if (this.FName.CompareTo(stud.FName) != 0)
            {
                return this.FName.CompareTo(stud.FName);
            }

            if (this.MName.CompareTo(stud.MName) != 0)
            {
                return this.MName.CompareTo(stud.MName);
            }
            if (this.LName.CompareTo(stud.LName) != 0)
            {
                return this.LName.CompareTo(stud.LName);
            }
            if (this.Ssn.CompareTo(stud.Ssn) != 0)
            {
                return this.Ssn.CompareTo(stud.Ssn);
            }

            return 0;
        }
        
    }
}