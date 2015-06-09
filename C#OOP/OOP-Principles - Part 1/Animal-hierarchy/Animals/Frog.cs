using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy.Animals
{
    class Frog:Animal,ISound
    {
     
            public Frog(string name, int age, Gender gend)
            : base(name,age,gend)
        {
         
        }


        public override void ProduceSound()
        {

            Console.WriteLine("Qua,qua,qua");
        }
    }
}
