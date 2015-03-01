/*Problem 4. Print a Deck of 52 Cards

    Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
        The card faces should start from 2 to A.
        Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

 */

using System;



class PrintADeckOf52Cards
{
    static void Main()
    {
        for (int i = 2; i <= 14; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                if (i == 11)
                {
                    Console.Write("J");
                }
                if (i == 12)
                {
                    Console.Write("Q");
                }
                if (i == 13)
                {
                    Console.Write("K");
                }
                if (i == 14)
                {
                    Console.Write("A");
                }
                if (2 <= i && i <= 10)
                {
                    Console.Write(""+i);
                }
                Console.Write("");
                switch (j)
                {
                    case 1: Console.Write(" of spades, ");
                        break;
                    case 2: Console.Write(" of clubs, ");
                        break;
                    case 3: Console.Write(" of hearts, ");
                        break;
                    case 4: Console.Write(" of diamonds, ");
                        break;
                    default:
                        break;

                }

            }
            Console.WriteLine();

        }
        Console.ReadLine();//pause
    }
}

