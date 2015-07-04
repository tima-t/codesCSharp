//-----------------------------------------------------------------------
// <copyright file="Person.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Task2.MakePerson
{
    using System;

    /// <summary>
    /// Enumeration for the gender
    /// </summary>
   public enum Gender
    { 
       /// <summary>
       /// for man
       /// </summary>
      strongMan,

       /// <summary>
       /// for girl
       /// </summary>
      prettyGirl 
    }

    /// <summary>
    /// Template for person
    /// </summary>
   public class Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="name">name of type string</param>
        /// <param name="gend">gender of type enumeration</param>
        /// <param name="age">age of type integer</param>
        public Person(string name, Gender gend, int age)
        {
            this.Name = name;
            this.Gend = gend;
            this.Age = age;
        }

        /// <summary>
        /// Gets or sets name of the person
        /// </summary>
        public Gender Gend { get; set; }

        /// <summary>
        /// Gets or sets gender of the person
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the person's age
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Override the to string method
        /// </summary>
        /// <returns> string with information</returns>
        public override string ToString()
        {
            return this.Name + " " + this.Gend + " " + this.Age;
        }
    }
}
