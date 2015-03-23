using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MatrTest
    {
        static void Main(string[] args)
        {
            Matrix<int> firstMatr = new Matrix<int>(3, 3);
            int z=1;
            for (int i = 0; i < 3; i++)
            {//fill matrix 1 //
                for (int j = 0; j < 3; j++)
                {
                    firstMatr[i, j] = z;
                    z += 2;
                }
            }
            Matrix<int> secondMatr = new Matrix<int>(3, 3);

            for (int i = 0; i < 3; i++)
            {//fill matrix 2 //
                for (int j = 0; j < 3; j++)
                {
                   secondMatr[i, j] = z;
                    z += 2;
                }
            }
            Console.WriteLine("first matrix is : ");
            Console.WriteLine(firstMatr.ToString());
            Console.WriteLine("second matrix is:");
            Console.WriteLine(secondMatr.ToString());
            Matrix<int> sum = firstMatr + secondMatr;
            Console.WriteLine("the sum is : ");
            Console.WriteLine(sum.ToString());
            Console.WriteLine("the result after - is ");
            Matrix<int> result = firstMatr - secondMatr;
            Console.WriteLine(result.ToString());
            Matrix<int> multiple = firstMatr * secondMatr;
            Console.WriteLine("after multiplication ; ");
            Console.WriteLine(multiple.ToString());
            




        }
    }
}
