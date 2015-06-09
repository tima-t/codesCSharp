using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal_hierarchy.Animals;

namespace Animal_hierarchy
{
    class AnimalHierarchyTest
    {
        public static void Main()
        {
            List<Animal> animals = new List<Animal>();

            Frog fr = new Frog("Pesho", 3, Gender.Male);
            Frog fr1 = new Frog("Pesho1", 32, Gender.Male);

            Dog spike = new Dog("Spike", 4, Gender.Male);
            Dog spike1 = new Dog("Spike1", 5, Gender.Male);

            Animal dobrinka = new Cat("dobrinka", 10, Gender.Female);
            Animal dobrinka1 = new Cat("dobrinka1", 14, Gender.Female);
            Console.WriteLine(dobrinka);

            Cat tomcat = new Tomcat("tom", 5);
            Cat tomcat1 = new Tomcat("tom1", 6);
            Console.WriteLine(tomcat);

            Cat kitten = new Kitten("kiti,", 4);
            Cat kitten1 = new Kitten("kiti1,", 7);


            animals.Add(fr);
            animals.Add(fr1);
            animals.Add(spike);
            animals.Add(spike1);
            animals.Add(dobrinka);
            animals.Add(dobrinka1);
            animals.Add(tomcat);
            animals.Add(tomcat1);
            animals.Add(kitten);
            animals.Add(kitten1);
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            dobrinka.ProduceSound();
            fr.ProduceSound();
            spike.ProduceSound();
            tomcat.ProduceSound();

            var frogs = animals.Where(an => (an is Frog));
            Console.WriteLine("frogs avg age is : {0}", frogs.Average(d => d.Age));
           
            var dogs = animals.Where(an => (an is Dog));
            Console.WriteLine("dogs avg age is : {0}", dogs.Average(d => d.Age));
            var cats = animals.Where(an => (an is Cat));
            Console.WriteLine("cats avg age is : {0}", cats.Average(d => d.Age));
           
             
        }

    

    }
}
