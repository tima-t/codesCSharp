
/* 9. Exchange Variable Values

    Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
    Print the variable values before and after the exchange.*/


using System;

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            int num1 = 5;
            int num2 = 10;
            int swap;
            Console.WriteLine("{0} {1} ",num1,num2);
            swap = num1;
            num1 = num2;
            num2 = swap;
            Console.WriteLine("{0} {1} ", num1, num2);
            Console.Read(); // pause 


        }
    }
}
