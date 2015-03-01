﻿
/*Problem 7. Quotes in Strings

    Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
    Do the above in two different ways - with and without using quoted strings.
    Print the variables to ensure that their value was correctly defined.*/



using System;


namespace QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main(string[] args)
        {
            string str1 = "The\"use\" of quotations causes difficulties.";
            string str2 = "The\u0022use\u0022 of quotations causes difficulties.";
            Console.WriteLine("{0} \n{1}",str1,str2);
            Console.Read(); //pause


        }
    }
}
