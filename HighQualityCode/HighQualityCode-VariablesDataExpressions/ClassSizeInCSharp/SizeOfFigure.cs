//-----------------------------------------------------------------------
// <copyright file="SizeOfFigure.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ClassSizeInCSharp
{
    using System;

    /// <summary>
    /// class that creates a figure with defined size
    /// </summary>
    public class SizeOfFigure
    {
        /// <summary>
        /// field that holds the width 
        /// </summary>
        private double width;

        /// <summary>
        /// field that holds the height
        /// </summary>
        private double height;

        /// <summary>
        /// Initializes a new instance of the <see cref="SizeOfFigure"/> class.
        /// </summary>
        /// <param name="width">double width</param>
        /// <param name="height">double height</param>
        public SizeOfFigure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets or sets width of the figure
        /// </summary>
        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("the width must be positive ");
                }

                this.width = value;
            }
        }

        /// <summary>
        /// Gets or sets height of the figure
        /// </summary>
        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("the height must be positive ");
                }

                this.height = value;
            }
        }

        /// <summary>
        /// Static method that return a new figure that is rotated
        /// </summary>
        /// <param name="figure">some figure</param>
        /// <param name="angleOfTheFigureThatWillBeRotaed">some angle</param>
        /// <returns>new rotated figure</returns>
        public static SizeOfFigure GetRotatedSize(SizeOfFigure figure, double angleOfTheFigureThatWillBeRotaed)
        {
            double widhtOfFigure = (Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * figure.Width) 
                                   + (Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * figure.Height);
            double heightOfFigure = (Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * figure.Width) 
                                    + (Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * figure.Height);
            return new SizeOfFigure(widhtOfFigure, heightOfFigure);
        }
    }
}
