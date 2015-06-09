using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy.Animals
{
    enum Gender
    {
        Male=1,
        Female=2
    }
   abstract  class Animal:ISound
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public  Gender Sex { get; set; }


        public abstract void ProduceSound();

        public Animal(string name, int age, Gender gend)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = gend;
        }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            
        }
        public override string ToString()
        {
            return this.Name + "  " + this.Age + "  " + this.Sex;
        }

       
    }
}
