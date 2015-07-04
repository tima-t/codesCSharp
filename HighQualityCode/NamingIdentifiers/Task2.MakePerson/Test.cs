//-----------------------------------------------------------------------
// <copyright file="Test.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Task2.MakePerson
{
    using System;

    /// <summary>
    /// Class to test the program
    /// </summary>
    public static class Test
    {
        /// <summary>
        /// The main method
        /// </summary>
      public static void Main()
        {
            Console.WriteLine(MakePerson("Ïvan", Gender.strongMan, 21));
            Console.WriteLine(MakePerson("Penka", Gender.prettyGirl, 28));
        }

        /// <summary>
        /// Method that make a person
        /// </summary>
        /// <param name="name"> name of type string</param>
        /// <param name="gend"> gender of type enumeration</param>
        /// <param name="age"> age of type integer</param>
        /// <returns>new Person</returns>
        public static Person MakePerson(string name, Gender gend, int age)
        {
            Person somePerson = new Person(name, gend, age);
            return somePerson;
        }
    }
}
