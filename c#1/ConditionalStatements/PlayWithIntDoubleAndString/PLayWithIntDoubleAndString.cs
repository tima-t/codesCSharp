/*Problem 9. Play with Int, Double and String

    Write a program that, depending on the user’s choice, inputs an int, double or string variable.
        If the variable is int or double, the program increases it by one.
        If the variable is a string, the program appends * at the end.
    Print the result at the console. Use switch statement.

 */


using System;



class PlayWithIntDoubleString
{
    static void Main()
    {

        Console.Write("write a digit 1- for int , 2 for double , 3 for string\nwrite your choice:   ");
        string digit = Console.ReadLine();
        switch (digit)
        {
            case "1":
                Console.Write("write your int number: ");
                int a = int.Parse(Console.ReadLine());
                a++;
                Console.WriteLine(a);
                break;
            case "2":
                Console.Write("write your double number: ");
                double b = double.Parse(Console.ReadLine());
                b++;
                Console.WriteLine(b);
                break;
            case "3":
                Console.Write("write your string: ");
                string yourString = Console.ReadLine() + "*";
                Console.WriteLine(yourString);

                break;
            default:
                Console.WriteLine("wrong input ");

                break;
        }
        Console.Read();//pause 

    }
}
