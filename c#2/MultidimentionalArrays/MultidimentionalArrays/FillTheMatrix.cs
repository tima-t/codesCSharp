using System;



class MultidimentionalArrays
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

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (col == 0 && row == 0)
                {
                    matrix[row, col] = row + 1;
                }
                matrix[row, col] = (row + 1) + col * n;
            }
        }
        PrintMatrix(matrix);

    }
}

