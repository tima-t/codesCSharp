//-----------------------------------------------------------------------
// <copyright file="Convertor.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace Task1.CovertingProgram
{
    using System;

    /// <summary>
    ///     Class Convertor
    /// </summary>
   public class Convertor
    {
        /// <summary>
        /// Convert true or false to String
        /// </summary>
        /// <param name="boolean">true or false</param>
       public void BoolToString(bool boolean)
        {
            string converted = boolean.ToString();
            Console.WriteLine(converted);
        }
    }
}
