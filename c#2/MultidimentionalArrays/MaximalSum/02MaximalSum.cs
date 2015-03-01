/*Problem 2. Maximal sum

    Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

 */

using System;



class Program
{
    public static void FillMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.WriteLine("matrix[{0},{1}]=", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());

            }
        }

    }
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
    public static void FindMaxMatrix3X3(int[,] matrix)
    {
        int maxSum = int.MinValue;
        int tempSum = 0;

        int[,] matrixMaxSum = new int[3, 3];
       
        for (int row = 2; row < matrix.GetLength(0); row++)
        {

            for (int col = 0; col <= matrix.GetLength(1)-3 ; col++)
            {
                tempSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    matrix[row - 1, col] + matrix[row - 1, col + 1] + matrix[row - 1, col + 2] +
                    matrix[row - 2, col] + matrix[row - 2, col + 1] + matrix[row - 2, col + 2];
                if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                    matrixMaxSum[0, 0] = matrix[row - 2, col];
                    matrixMaxSum[0, 1] = matrix[row - 2, col + 1];
                    matrixMaxSum[0, 2] = matrix[row - 2, col + 2];
                    matrixMaxSum[1, 0] = matrix[row - 1, col];
                    matrixMaxSum[1, 1] = matrix[row - 1, col + 1];
                    matrixMaxSum[1, 2] = matrix[row - 1, col + 2];
                    matrixMaxSum[2, 0] = matrix[row, col];
                    matrixMaxSum[2, 1] = matrix[row, col + 1];
                    matrixMaxSum[2, 2] = matrix[row, col + 2];
                }
            }
            tempSum = 0;
        }
        Console.WriteLine("The max sum is {0}",maxSum);
        PrintMatrix(matrixMaxSum);

    }





    static void Main()
    {
        Console.Write("write the size of the rectangle  matrix n ,  n=   ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("write the size of the rectangle  matrix m ,  m=   ");
        int m = int.Parse(Console.ReadLine());

        if (m < 3 || n < 3)
        {
            Console.WriteLine("wrong input");
            return;
        }
        int[,] matrix = new int[n, m];

        FillMatrix(matrix);
        Console.WriteLine("your matrix is : ");
        Console.WriteLine();
        PrintMatrix(matrix);
        Console.WriteLine("the matrix 3X3 with max sum is : ");
        Console.WriteLine();
        FindMaxMatrix3X3(matrix);





    }
}

