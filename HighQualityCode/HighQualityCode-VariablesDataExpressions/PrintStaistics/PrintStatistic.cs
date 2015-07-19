//-----------------------------------------------------------------------
// <copyright file="PrintStatistic.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace PrintStaistics
{
    using System;

    /// <summary>
    /// Class that test the method print statistics
    /// </summary>
   public static class PrintStatistic
    {
        /// <summary>
        /// The main method of the class that test the main function
        /// </summary>
       public static void Main()
        {
            double[] results = new double[6]
            {
                5, 6, 7.8, 10, 11, 5.5
            };

            int count = 6;
            PrintStatistics(results, count);
        }

        /// <summary>
        /// Method that prints all statistics
        /// </summary>
        /// <param name="results"> result of type double array</param>
        /// <param name="count">the count of the elements of array</param>
        public static void PrintStatistics(double[] results, int count)
        {
            Console.WriteLine("the max result is {0}", GetMaxResult(results, count));
            Console.WriteLine("the min result is {0}", GetMinResult(results, count));
            Console.WriteLine("the average of all results is {0}", GetAverageResult(results, count));   
        }

        /// <summary>
        /// Returns the max result
        /// </summary>
        /// <param name="results">some double array</param>
        /// <param name="count">the count of elements</param>
        /// <returns>the max element</returns>
        private static double GetMaxResult(double[] results, int count)
        {
            double maxResult = double.MinValue;
            for (int i = 0; i < count; i++)
            {
                if (results[i] > maxResult)
                {
                    maxResult = results[i];
                }
            }

            return maxResult;
        }

        /// <summary>
        /// Returns the min result
        /// </summary>
        /// <param name="results">some double array</param>
        /// <param name="count">the count of elements</param>
        /// <returns>the min element</returns>
        private static double GetMinResult(double[] results, int count)
        {
            double minResult = double.MaxValue;
            for (int i = 0; i < count; i++)
            {
                if (results[i] < minResult)
                {
                    minResult = results[i];
                }
            }

            return minResult;
        }

        /// <summary>
        /// Returns the average result
        /// </summary>
        /// <param name="results">some double array</param>
        /// <param name="count">the count of elements</param>
        /// <returns>the average of all elements</returns>
        private static double GetAverageResult(double[] results, int count)
        {
            double sumOfResults = 0;
            for (int i = 0; i < count; i++)
            {
                sumOfResults += results[i];
            }

            double averageResult = sumOfResults / count;
            return averageResult;
        }
    }
}
