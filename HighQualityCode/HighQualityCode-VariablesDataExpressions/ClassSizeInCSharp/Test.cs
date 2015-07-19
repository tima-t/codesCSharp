//-----------------------------------------------------------------------
// <copyright file="Test.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ClassSizeInCSharp
{
    using System;

    /// <summary>
    /// we do the test in the main method
    /// </summary>
   public class Test
    {
       /// <summary>
       /// the main method of class test
       /// </summary>
      public static void Main()
        {
            SizeOfFigure figure = new SizeOfFigure(5, 6.6);
            var newFigure = SizeOfFigure.GetRotatedSize(figure, 6.7);
            Console.WriteLine(newFigure.Width);
            Console.WriteLine(newFigure.Height);
        }
    }
}
