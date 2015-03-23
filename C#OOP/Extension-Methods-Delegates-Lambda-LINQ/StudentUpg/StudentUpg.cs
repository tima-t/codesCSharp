using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentUpg
{
    class StudentUpg
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string fn;
        public string PhoneNumber { get;set; }
        public string Email { get; set; }

        private List<int> marks;

        public List<int> Marks
        {
            get
            {
                return this.marks;
            }

            set
            {
                foreach (var mark  in value)
                {
                    if (mark < 2 || mark > 6)
                    {
                        throw new ArgumentOutOfRangeException("there is invalid mark ");

                    }
                }

                this.marks = value;
            }
        }

        private int groupNumber;
       
       


        public string FN
        {
            get
            {
                return this.fn;

            }
            set
            {
                if (value.Length >4 && value.Length<11)
                {
                    this.fn = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid age ");
                }

            }
        }


        public int GroupNumber
        {
            get
            {
                return this.groupNumber;

            }
            set
            {
                if (value >= 0 && value < 500)
                {
                    this.groupNumber = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid age ");
                }

            }
        }


            public StudentUpg(string fName, string lName,string fn,string phone , string email,List<int> marks,int group)
            {
                this.FirstName=fName;
                this.LastName=lName;
                this.FN = fn;
                this.PhoneNumber=phone;
                this.Email=email;
                this.Marks=marks;
                this.GroupNumber=group;
            }

            public override string ToString()
            {
                string result = this.FirstName +"  " + this.LastName+ "    "+ this.FN + this.PhoneNumber+ "   " + this.Email +"  " +  this.groupNumber +"  "+  "marks : " + "(" + String.Join(",", this.Marks) + ")";
                return result;
            }
        }
    }


