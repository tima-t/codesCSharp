using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_extensions
{
    public static class IEnumerableExtensions
    {
        public static T SumMy<T>(this IEnumerable<T> array) where T : struct 
	
        {
            T result = (dynamic)0;

            foreach (T item in array)
            {
                result += (dynamic)item;
            }

            return result;
        }

        public static T MultipleMy<T>(this IEnumerable<T> array) where T : struct
        {
            T result = (dynamic)1;

            foreach (var item in array)
            {
                result= result* (dynamic)item;
            }
            return result;
        }

        public static T MinMy<T>(this IEnumerable<T> array)
        {
            return array.Min();
        }

        public static T MaxMy<T>(this IEnumerable<T> collection) where T : struct
        {
            return collection.Max();
        }
        public static double AverageMy<T>(this IEnumerable<T> collection) where T : struct
        {
            return collection.SumMy()/(dynamic)collection.Count();
        }
    }
}
