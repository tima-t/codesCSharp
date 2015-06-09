using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        public string Name { get; set; }
        public int? Age { get; set; }

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
            this.ToString();
        }

        public override string ToString()
        {
            string result =this.Name + "  " + this.Age;

            if (this.Age==null)
            {
                Console.WriteLine("you should enter valid  age for {0} : ", this.Name);
                this.Age = int.Parse((Console.ReadLine()));
                return null;
            }
            else
            {
                return result;
            }
        
        }
    }
}
