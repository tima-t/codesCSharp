using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingPolynomials
{
    class AddingPolynomials
    {
        public static void RepresentCoeficient(string polynomial)
        {

            string[] subStrings = polynomial.Split(new char[] { '+' }, StringSplitOptions.RemoveEmptyEntries); ;
            List<string> coeficients = new List<string>();
            string temp = "";


            for (int i = 0; i < subStrings.Length; i++)
            {
                for (int j = 0; j < subStrings[i].Length; j++)
                {
                    if (subStrings[i][j] == 'x')
                    {

                        if (j == 0)
                        {
                            temp = "1";
                        }
                        if (j > 0)
                        {


                            if (subStrings[i][j - 1] == ' ')
                            {
                                temp = "1";
                            }

                        }
                        break;
                    }

                    else
                    {
                        temp = temp + " " + subStrings[i][j];
                    }
                }
                coeficients.Add(temp);
                temp = "";


            }
            coeficients.Reverse();
            foreach (var item in coeficients)
            {
                Console.Write("  {0}", item);
            }
        }
        static void Main()
        {
            Console.WriteLine(" write first polynomial in type ( no * for myltiple)  x^n + 5x^n-1 ... + 2x + 30 ( only exmple): ");
            string firstPolynomial = Console.ReadLine();
            Console.WriteLine("write you second polynomial  in type ( no * for myltiple)  x^n + 5x^n-1 ... + 2x + 30 ( only exmple): ");
            string secondPolynomial = Console.ReadLine();
            Console.Write(" the coeficients of your first polynomial are ");
            RepresentCoeficient(firstPolynomial);
            Console.WriteLine();
            Console.Write(" the coeficients of your second polynomial are ");
            RepresentCoeficient(secondPolynomial);
            Console.WriteLine();


        }
    }
}
