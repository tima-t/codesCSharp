/*Problem 3. Sequence n matrix

    We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
    Write a program that finds the longest sequence of equal strings in the matrix.

 */

using System;


namespace SequenceNMAtrix
{

    class SequenceNMAtrix
    {
        public static void FillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.WriteLine("matrix[{0},{1}]=", row, col);
                    matrix[row, col] = Console.ReadLine();

                }
            }

        }



        static void Main()
        {
            Console.Write("write the size of the rectangle  matrix n ,  n=   ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("write the size of the rectangle  matrix m ,  m=   ");
            int m = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, m];
            FillMatrix(matrix);
            int row = 0;
            int col = 0;
            int diagonalCounter=0;
            int maxDiagonalCounter = int.MinValue;
            int horizontCounter=1;
            int maxHorizontalCounter = int.MinValue;

            int vertikalCounter = 1;
            int maxvertikalCounter = 1;
            string searchedElement1="";
            string searchedElement2="";
            string searchedElement3="";;

            string tempElement=matrix[0,0];


            for (int i = 0; i < n; i++)
            {

                while (row < n && col+i < m)
                {
                    if (tempElement == matrix[row, col + i])
                    {
                        diagonalCounter++;
                        if (diagonalCounter>maxDiagonalCounter)
                        {
                            maxDiagonalCounter = diagonalCounter;
                            searchedElement1 = tempElement;
                        }
                    }
                    else
                    {
                        break;
                    }
                    row++;
                    col++;
                   
                }
                 diagonalCounter = 0;
                row = 0;
                col = 0;
                while (row+i < n && col < m)
                {
                    if (tempElement == matrix[row+i, col])
                    {
                       horizontCounter++;
                        if (horizontCounter > maxHorizontalCounter)
                        {
                            maxHorizontalCounter = horizontCounter;
                            searchedElement2 = tempElement;
                        }
                    }
                    

                    else
                    {
                        break;
                    }
                    col++;
                    
                  
                }

                row = 0;
                col = 0;

                
                horizontCounter = 0;
                while (row < n && col+i < m)
                {
                    if (tempElement == matrix[row, col + i])
                    {
                       vertikalCounter++;
                        if (vertikalCounter > maxvertikalCounter)
                        {
                            maxvertikalCounter = vertikalCounter;
                            searchedElement3 = tempElement;
                        }
                    }


                    else
                    {
                        break;
                    }
                    row++;


                }
                row = 0;
                col = 0;
                vertikalCounter = 0;

            }

            if (maxDiagonalCounter>maxHorizontalCounter&&maxDiagonalCounter>maxvertikalCounter)
            {

                for (int i = 0; i < maxDiagonalCounter; i++)
                {
                    Console.Write("{0} ",searchedElement1);
                }
                Console.WriteLine();
                return;
            }
            if (maxHorizontalCounter>maxDiagonalCounter&& maxHorizontalCounter>maxvertikalCounter)
            {
                for (int i = 0; i < maxHorizontalCounter; i++)
                {
                    Console.Write("{0} ", searchedElement2);
                }
                Console.WriteLine();
                return;
                
            }
            if (maxvertikalCounter>maxHorizontalCounter && maxvertikalCounter>maxDiagonalCounter)

            {
                   for (int i = 0; i < maxvertikalCounter; i++)
                {
                    Console.Write("{0} ", searchedElement3);
                }
                   Console.WriteLine();
                   return;
            }
            Console.WriteLine("wrong input there are two or more equal sequences");
    
            
                
            

        }
    }
}
