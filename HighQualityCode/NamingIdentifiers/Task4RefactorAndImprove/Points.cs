//-----------------------------------------------------------------------
// <copyright file="Points.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Task4RefactorAndImprove
{
    using System;

    /// <summary>
    /// Points class
    /// </summary>
    public class Points
    {
        /// <summary>
        /// name of the class
        /// </summary>
       private string name;

        /// <summary>
        /// points of the class
        /// </summary>
       private int point;

        /// <summary>
        /// Initializes a new instance of the <see cref="Points"/> class.
        /// </summary>
        public Points() 
        { 
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Points"/> class.
        /// </summary>
        /// <param name="name">string name</param>
        /// <param name="point"> integer point</param>
        public Points(string name, int point)
        {
            this.Name = name;
            this.Point = point;
        }

        /// <summary>
        /// Gets or sets name
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Gets or sets points
        /// </summary>
        public int Point
        {
            get { return this.point; }
            set { this.point = value; }
        }
    }
}
