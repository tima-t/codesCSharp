/*Problem 8. Prime Number Check

    Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

 */


using System;


namespace PrimeNumberCheck
{

    class PrimeNumberCheck
    {

        static bool IsPrime(int number)
        {
            if (number == 1)
            {
                return false;

            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0 && i != number)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main()
        {
            Console.Write("write your positive number and we will check if it is prime number ");
            int number = int.Parse(Console.ReadLine());
            if (number <= 0)
            {
                Console.WriteLine("wrong input : False ");
            }
            else
            {
                Console.WriteLine(" your number ({0})  is prime : {1}", number, IsPrime(number));

            }
            Console.Read();
        }
    }
}
