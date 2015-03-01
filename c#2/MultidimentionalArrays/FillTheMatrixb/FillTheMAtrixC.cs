
using System;



    class FillTheMAtrixC
    {
        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,3} ", matrix[row, col]);
                }
                Console.WriteLine();
            }

        }
        static void Main()
        {
            Console.Write("write the size of the square  matrix n ,  n=   ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int digit = 1;
            int row = n - 1;
            int col = 0;
            int startRow = n - 1;
            int startCol = 0;
            while (digit < n * n)
            {
                if (row == (n - 1) && col < (n - 1)) //Filling matrix
                {
                    if (digit == 1)
                    {
                        matrix[row,col] = digit;
                    }
                    startRow--;
                    startCol = 0;
                    row = startRow;
                    col = startCol;
                    digit++;
                    matrix[row,col] = digit;
                    while (row < (n - 1) && col < (n - 1))
                    {
                        row++;
                        col++;
                        digit++;
                        matrix[row,col] = digit;
                    }
                }
                if (row <= (n - 1) && col == (n - 1))
                {
                    startRow = 0;
                    startCol++;
                    row = startRow;
                    col = startCol;
                    digit++;
                    matrix[row,col] = digit;
                    while (col < (n - 1))
                    {
                        col++;
                        row++;
                        digit++;
                        matrix[row,col] = digit;
                    }
                }
            }
            PrintMatrix(matrix);



        }
    }

