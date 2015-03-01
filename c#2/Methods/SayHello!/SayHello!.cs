using System;


namespace SayHello_
{
    class Program
    {
        public static void SayHello()
        {
            Console.Write("Write your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello ,{0} ! ",name);
        }
        static void Main()
        {
            SayHello();
        }
    }
}
