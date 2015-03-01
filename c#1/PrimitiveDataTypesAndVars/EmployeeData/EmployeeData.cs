/*Problem 10. Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:

    First name
    Last name
    Age (0...100)
    Gender (m or f)
    Personal ID number (e.g. 8306112507)
    Unique employee number (27560000…27569999)

Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
*/
using System;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("write your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("write your last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("write your age");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("write your gender m/f");
            char gender=char.Parse(Console.ReadLine());
            Console.WriteLine("write you id number");
            long idNumber=long.Parse(Console.ReadLine());
            Console.WriteLine("write your unique employee number");
            long uniquesEmployeeNumber=long.Parse(Console.ReadLine());
            Console.WriteLine(" your data is :\n{0}\n{1}\n{2}\n{3}\n{4}\n{5}",firstName,lastName,age,gender,idNumber,uniquesEmployeeNumber);
            Console.Read(); // pause



        }
    }
}
