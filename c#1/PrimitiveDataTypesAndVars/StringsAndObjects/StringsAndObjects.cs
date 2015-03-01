
   /* Declare two string variables and assign them with Hello and World.
    Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
    Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).*/


using System;


namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "world";

            object obj1 = str1 + " " + str2;
             
            string str3=(string) obj1;
            Console.WriteLine(str3);
            Console.Read(); //pause



        }
    }
}
