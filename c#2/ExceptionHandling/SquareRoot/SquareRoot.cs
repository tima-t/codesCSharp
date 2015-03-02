using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            Console.Write("write your number : ");
            try
            {
              double number = double.Parse(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine("Your number should be positive");
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    Console.WriteLine("Square root = {0}", Math.Sqrt(number));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Value not entered");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Value overflowed");
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);

            }
            finally
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
