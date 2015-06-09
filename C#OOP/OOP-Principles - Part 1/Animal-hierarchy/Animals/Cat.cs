using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy.Animals
{
    class Cat : Animal, ISound
    {
        
        public Cat(string name, int age, Gender gend)
            : base(name, age, gend)
        {

        }

        public Cat(string name, int age)
            : base(name, age)
        {

        }
       

     


        public override void ProduceSound()
        {

            Console.WriteLine("Mya, mya , mya ");
        }
    }
}
