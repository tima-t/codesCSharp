/*Problem 2. Bonus Score

    Write a program that applies bonus score to given score in the range [1…9] by the following rules:
        If the score is between 1 and 3, the program multiplies it by 10.
        If the score is between 4 and 6, the program multiplies it by 100.
        If the score is between 7 and 9, the program multiplies it by 1000.
        If the score is 0 or more than 9, the program prints “invalid score”.

 */

using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("write your score and we will calculate the bonus\nscore=  ");
        int score = int.Parse(Console.ReadLine());
        if (1 <= score && score <= 3)
        {
            score = score * 10;
            Console.WriteLine("your result is {0}", score);

        }
        if (4 <= score && score <= 6)
        {
            score = score * 100;
            Console.WriteLine("your result is {0}", score);
        }
        if (7 <= score && score <= 9)
        {
            score = score * 1000;
            Console.WriteLine("your result is {0}", score);
        }
        if ( 1> score || score >9)
        {
            Console.WriteLine("invalid score");
        }

     
        Console.ReadLine();//pause 


    }
}

