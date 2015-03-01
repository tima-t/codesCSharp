using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrix
{
    class FillTheMatrix
    {

      /*  public static int[] FillARow(int n,int downCustom, int upCustom)
        {
            int[] tempArray = new int[n];
            for (int i = downCustom; i < upCustom; i++)
            {
                tempArray[i] = i;
                
            }
            return tempArray;
        }*/
        public static void PrintMatrix(int [,] matrix)
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
            int[] tempMatrix = new int[n];
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (col == 0 && row == 0)
                    {
                        matrix[row, col] = row + 1;
                    }
                    if (col % 2 == 0)
                    {
                        matrix[row, col] = (row + 1) + col * n;
                    }
                    else
                    {
                        matrix[n - row-1, col] = (row + 1) + col * n;
                    }
                }
            }

            PrintMatrix(matrix);

        }
    }
}
