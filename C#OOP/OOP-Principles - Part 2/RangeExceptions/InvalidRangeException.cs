﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    class InvalidRangeException<T> : ApplicationException
     where T : IComparable<T>
    {
       public T Start{get;set;}
       public T End { get; set; }

        public InvalidRangeException(string message, T start, T end, Exception e)
            : base(String.Format("{0}\nParameter should be in range[{1}; {2}]", message, start, end), e)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string message, T start, T end)
            : this(message, start, end, null) { }




  

       
    }
}
