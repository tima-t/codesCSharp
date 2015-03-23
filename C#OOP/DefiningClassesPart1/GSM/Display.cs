using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class Display
    {
        private double size;
        private long numberOfColours;


        public Display(double size, long number)
        {
            this.Size = size;
            this.NumberOfColours = number  ;
        }

        public Display( long number)
        {
           
            this.NumberOfColours = number;
        }


        public double Size
        {
            get
            {
                return size;
            }
            set
            {
                if (size<0)
                {
                    throw new ArgumentException("the inches of the display should be a positive number");
                }
                size = value;
            }
        }

        public long NumberOfColours
        {
            get
            {
                return numberOfColours;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("colours should be more than zero ");
                }
                numberOfColours = value;
            }
        }
    }
}
