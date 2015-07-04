//-----------------------------------------------------------------------
// <copyright file="Test.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Task1.CovertingProgram
{
    using System;

    /// <summary>
    /// Test class
    /// </summary>
   public static class Test
    {  
       /// <summary>
       /// Constant for the max count
       /// </summary>
       public const int MaxCount = 6;

       /// <summary>
       /// Main method
       /// </summary>
       public static void Main()
        {
            Convertor convertor = new Convertor();
            convertor.BoolToString(false);
        }
    }
}
