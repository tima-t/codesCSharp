/*
 Problem 2. Print Company Information

    A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
    Write a program that reads the information about a company and its manager and prints it back on the console.

 */
using System;



    class PrintCompany
    {
        static void Main()
        {
            Console.Write("Write the company name ");
            string companyName=Console.ReadLine();
            Console.Write("Write the company address");
            string companyAddress=Console.ReadLine();
            Console.Write("Write the phone number of company" );
            long companyNumber=int.Parse(Console.ReadLine());
            Console.Write("write the fax number ");
            int faxnumber=int.Parse(Console.ReadLine());
            Console.Write("write your website");
            string webSite= Console.ReadLine();
            Console.Write("write manager's first name");
            string managerFirstName=Console.ReadLine();
            Console.Write("write manager's last name ");
            string managerLastName=Console.ReadLine();
            Console.Write("write manager's age ");
            byte age=byte.Parse(Console.ReadLine());
            Console.Write("write manager's phone number");
            long managerNumber = long.Parse(Console.ReadLine());
            Console.Write("{0}\nAdress:{1}\nTel:{2}\nFax {3}\nWeb Site:{4}\nManager:{5} {6} ( age: {7}, Tel {8})", companyName, companyAddress, companyNumber, faxnumber, webSite, managerFirstName, managerLastName, age, managerNumber);
            Console.ReadLine();//pause

        }


    }

