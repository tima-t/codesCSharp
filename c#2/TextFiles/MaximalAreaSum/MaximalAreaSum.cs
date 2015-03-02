using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MaximalAreaSum
{
    class MaximalAreaSum
    {

        static int[,] ReadMatrix()
        {
            
            using (StreamReader readeMatrix = new StreamReader(@"..\..\Matrix.txt"))
            {
                int n = int.Parse(readeMatrix.ReadLine());
                int[,] matrix = new int[n, n];
                string rowInfo;
                for (int row = 0; row < n; row++) 
                {
                    rowInfo = readeMatrix.ReadLine();
                    string[] rowCells = rowInfo.Split(' ');
                    for (int col = 0; col < n; col++)
                    {
                        matrix[row, col] = int.Parse(rowCells[col]);
                    }
                }
                return matrix;
            }
        }
        static int MaxSum(int[,] matrix)
        {
            int maxSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++) 
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
            return maxSum;
        }
        static void PrintResult(int maxSum)
        {
            using (StreamWriter resultWriter = new StreamWriter((@"..\..\MaxSum.txt")))
            {
                resultWriter.WriteLine(maxSum);
            }
        }
        static void Main()
        {
            PrintResult(MaxSum(ReadMatrix()));
            Console.WriteLine("Max sum is in the MaxSum.txt!");// output files are in current folder
        }

    }
}
