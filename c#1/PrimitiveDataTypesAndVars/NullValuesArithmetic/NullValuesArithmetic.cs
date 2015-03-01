
/*Problem 12. Null Values Arithmetic

    Create a program that assigns null values to an integer and to a double variable.
    Try to print these variables at the console.
    Try to add some number or the null literal to these variables and print the result.
*/


using System;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? var1=null;
            double? var2 = null;
            Console.WriteLine("{0} {1}",var1,var2);
            var1 += 5;
            var2 = 5;
             Console.WriteLine("{0} {1}",var1,var2);
            Console.Read();
        }
    }
}
