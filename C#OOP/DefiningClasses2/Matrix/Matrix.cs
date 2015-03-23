using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
   
    class Matrix<T>
        where T:IComparable
    {

        private int rows;
        private int cols;
        private T[,] matrix;
        public Matrix(int rowCout, int colCount)
        {
            this.rows = rowCout;
            this.cols = colCount;
            this.matrix = new T[rowCout, colCount];
        }

        public int Rows {
            get {
            return this.rows;
             }

            private  set {
            this.rows=value;
            }
        }
        public int Cols
        {
            get
            {
                return this.cols;
            }
            private set{
            this.cols = value    ;
            }
        }
        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || row >= this.rows) ||
                    (col < 0 || col >=this.cols))
                {
                    throw new IndexOutOfRangeException();
                }
                T result = this.matrix[row, col];
                return result;
            }

            set
            {
                if ((row < 0 || row >= this.rows) ||
                    (col < 0 || col >= this.cols))
                {
                    throw new IndexOutOfRangeException();
                }
                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {
            if (a.Cols != b.Cols || a.Rows != b.Rows)
            {
                throw new Exception("Addition cannot be applied to matrices with different dimensions.");
            }
            Matrix<T> result = new Matrix<T>(a.Rows, a.Cols);
            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < a.Cols; col++)
                {
                    result[row, col] = (dynamic)a[row, col] + b[row, col];
                }
            }
            return result;
        }
        public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
        {
            if (a.Cols != b.Cols || a.Rows != b.Rows)
            {
                throw new Exception("Substraction cannot be applied to matrices with different dimensions.");
            }
            Matrix<T> result = new Matrix<T>(a.Rows, a.Cols);
            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < a.Cols; col++)
                {
                    result[row, col] = (dynamic)a[row, col] - b[row, col];
                }
            }
            return result;
        }
        public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
        {
            if (a.Cols != b.Rows)
            {
                throw new Exception("The matrices cannot be multiplied.");
            }
            Matrix<T> result = new Matrix<T>(a.Rows, b.Cols);
            T temp;
            for (int matrixRow = 0; matrixRow < result.Rows; matrixRow++)
            {
                for (int matrixCol = 0; matrixCol < result.Cols; matrixCol++)
                {
                    temp = (dynamic)0;
                    for (int index = 0; index < result.Cols; index++)
                    {
                        temp += (dynamic)a[matrixRow, index] * b[index, matrixCol];
                    }
                    result[matrixRow, matrixCol] = (dynamic)temp;
                }
            }
            return result;
        }
        private static bool OverrideBool(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col] != (dynamic)0)
                        return true;
                }
            }
            return false;
        }
        public static bool operator true(Matrix<T> matrix)
        {
            return OverrideBool(matrix);
        }
        public static bool operator false(Matrix<T> matrix)
        {
            return OverrideBool(matrix);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.rows; i++)
            {
                for (int j= 0; j < this.cols; j++)
                {
                    result.Append(this.matrix[i, j] + "  ");
                }
                result.Append("\n");
            }
            return result.ToString();
        }
    }
}
