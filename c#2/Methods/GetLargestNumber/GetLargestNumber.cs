using System;



    class GetLargestNumber
    {
        public static int GetMax( int a , int b )
        {
            if (a >= b)
            {
                return a;

            }
            else return b;

        }
        static void Main(string[] args)
        {
            Console.Write("write your first Number ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("write your second Number ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("write your third Number ");
            int thirdNumber = int.Parse(Console.ReadLine());
           firstNumber= GetMax(firstNumber, secondNumber);
           Console.WriteLine("the largest number is {0}", GetMax(firstNumber, thirdNumber));
        }
    }

