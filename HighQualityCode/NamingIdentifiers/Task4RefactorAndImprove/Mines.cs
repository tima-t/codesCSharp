//-----------------------------------------------------------------------
// <copyright file="Mines.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Task4RefactorAndImprove
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class for mines
    /// </summary>
   public class Mines
    {
       /// <summary>
       /// this is the engine
       /// </summary>
       public static void Main()
        {
            string command = string.Empty;
            char[,] cells = CreatePlayField();
            char[,] bombs = SetBombs();
            int counter = 0;
            bool overBomb = false;
            List<Points> bestPlayers = new List<Points>(6);
            int row = 0;
            int col = 0;
            bool flag = true;
            const int Maximum = 35;
            bool flag2 = false;
            int fieldLength = cells.GetLength(0);
            int fieldHeight = cells.GetLength(1);
            do
            {
                if (flag)
                {
                    Console.WriteLine("Lets play Mines Weaper .\nYou should find all free cells." +
                    " \n'top' shows the top players list \n'restart' begins new game, 'exit' to close the game!");
                    DrawField(cells);
                    flag = false;
                }

                Console.Write("Write row and coll with single space  : ");
                command = Console.ReadLine().Trim();
                if (command.Length == 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= fieldLength && col <= fieldHeight)
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        TopPlayers(bestPlayers);
                        break;
                    case "restart":
                        cells = CreatePlayField();
                        bombs = SetBombs();
                        DrawField(cells);
                        overBomb = false;
                        flag = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, bye !");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                YourTurn(cells, bombs, row, col);
                                counter++;
                            }

                            if (Maximum == counter)
                            {
                                flag2 = true;
                            }
                            else
                            {
                                DrawField(cells);
                            }
                        }
                        else
                        {
                            overBomb = true;
                        }

                        break;

                    default:
                        Console.WriteLine("\nInvalid command\n");
                        break;
                }

                if (overBomb)
                {
                    DrawField(bombs);
                    Console.Write("\nYou died with {0} to4ki. " + "Write your name : ", counter);
                    string name = Console.ReadLine();
                    Points currentPoints = new Points(name, counter);
                    if (bestPlayers.Count < 5)
                    {
                        bestPlayers.Add(currentPoints);
                    }
                    else
                    {
                        for (int i = 0; i < bestPlayers.Count; i++)
                        {
                            if (bestPlayers[i].Point < currentPoints.Point)
                            {
                                bestPlayers.Insert(i, currentPoints);
                                bestPlayers.RemoveAt(bestPlayers.Count - 1);
                                break;
                            }
                        }
                    }

                    bestPlayers.Sort((Points r1, Points r2) => r2.Name.CompareTo(r1.Name));
                    bestPlayers.Sort((Points r1, Points r2) => r2.Point.CompareTo(r1.Point));
                    TopPlayers(bestPlayers);

                    cells = CreatePlayField();
                    bombs = SetBombs();
                    counter = 0;
                    overBomb = false;
                    flag = true;
                }

                if (flag2)
                {
                    Console.WriteLine("\nGreat! You win.");
                    DrawField(bombs);
                    Console.WriteLine("Write your name champion: ");
                    string name = Console.ReadLine();
                    Points winnerPoints = new Points(name, counter);
                    bestPlayers.Add(winnerPoints);
                    TopPlayers(bestPlayers);
                    cells = CreatePlayField();
                    bombs = SetBombs();
                    counter = 0;
                    flag2 = false;
                    flag = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria !");
            Console.WriteLine("Have a nice day");
            Console.Read();
        }

       /// <summary>
       /// Show list with top players
       /// </summary>
       /// <param name="points"> points of type List</param>
        private static void TopPlayers(List<Points> points)
        {
            Console.WriteLine("\nScore:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells", i + 1, points[i].Name, points[i].Point);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("no points!\n");
            }
        }

       /// <summary>
       ///  Method for each turn
       /// </summary>
       /// <param name="field"> matrix symbol type</param>
       /// <param name="bombs"> symbol type</param>
       /// <param name="row"> row integer</param>
       /// <param name="coll"> column integer</param>
        private static void YourTurn(char[,] field, char[,] bombs, int row, int coll)
        {
            char howMuchBombs = HowMuch(bombs, row, coll);
            bombs[row, coll] = howMuchBombs;
            field[row, coll] = howMuchBombs;
        }

       /// <summary>
       /// This method draws the field
       /// </summary>
       /// <param name="board"> board of type symbols</param>
        private static void DrawField(char[,] board)
        {
            int boardLength = board.GetLength(0);
            int boardHeight = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < boardLength; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < boardHeight; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

       /// <summary>
       /// This method fill the filed with '?'
       /// </summary>
       /// <returns> return symbol matrix</returns>
        private static char[,] CreatePlayField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

       /// <summary>
       /// This method sets the bombs
       /// </summary>
       /// <returns>return matrix with symbols</returns>
        private static char[,] SetBombs()
        {
            int rows = 5;
            int colls = 10;
            char[,] playField = new char[rows, colls];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colls; j++)
                {
                    playField[i, j] = '-';
                }
            }

            List<int> listWithRandomNumbersToSetBombs = new List<int>();
            while (listWithRandomNumbersToSetBombs.Count < 15)
            {
                Random randomMagicNumber = new Random();
                int currNumber = randomMagicNumber.Next(50);
                if (!listWithRandomNumbersToSetBombs.Contains(currNumber))
                {
                    listWithRandomNumbersToSetBombs.Add(currNumber);
                }
            }

            int row;
            int coll;
            foreach (int number in listWithRandomNumbersToSetBombs)
            {
                  coll = number / colls;
                  row = number % colls;
                if (row == 0 && number != 0)
                {
                    coll--;
                    row = colls;
                }
                else
                {
                    row++;
                }

                playField[coll, row - 1] = '*';
            }

            return playField;
        }

       /// <summary>
       /// This method make some calculations
       /// </summary>
       /// <param name="field"> matrix of type symbols</param>
        private static void Calculations(char[,] field)
        {
            int rows = field.GetLength(0);
            int colls = field.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colls; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char countOfMinesAround = HowMuch(field, i, j);
                        field[i, j] = countOfMinesAround;
                    }
                }
            }
        }

       /// <summary>
       /// This method shows the count of bombs around a cell
       /// </summary>
       /// <param name="field">field matrix</param>
       /// <param name="row"> integer row</param>
       /// <param name="coll"> integer column</param>
       /// <returns>the count of mines around the cell</returns>
        private static char HowMuch(char[,] field, int row, int coll)
        {
            int minesAroundCell = 0;
            int rows = field.GetLength(0);
            int colls = field.GetLength(1);

            if (row - 1 >= 0)
            {
                if (field[row - 1, coll] == '*')
                {
                    minesAroundCell++;
                }
            }

            if (row + 1 < rows)
            {
                if (field[row + 1, coll] == '*')
                {
                    minesAroundCell++;
                }
            }

            if (coll - 1 >= 0)
            {
                if (field[row, coll - 1] == '*')
                {
                    minesAroundCell++;
                }
            }

            if (coll + 1 < colls)
            {
                if (field[row, coll + 1] == '*')
                {
                    minesAroundCell++;
                }
            }

            if ((row - 1 >= 0) && (coll - 1 >= 0))
            {
                if (field[row - 1, coll - 1] == '*')
                {
                    minesAroundCell++;
                }
            }

            if ((row - 1 >= 0) && (coll + 1 < colls))
            {
                if (field[row - 1, coll + 1] == '*')
                {
                    minesAroundCell++;
                }
            }

            if ((row + 1 < rows) && (coll - 1 >= 0))
            {
                if (field[row + 1, coll - 1] == '*')
                {
                    minesAroundCell++;
                }
            }

            if ((row + 1 < rows) && (coll + 1 < colls))
            {
                if (field[row + 1, coll + 1] == '*')
                {
                    minesAroundCell++;
                }
            }

            return char.Parse(minesAroundCell.ToString());
        }
    }
}