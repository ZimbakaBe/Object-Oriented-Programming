using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CustomLinqExtMeth
{
    static class Extensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            return collection.Where(item => !predicate(item)).ToList();

            //var list = new List<T>();
            //foreach (var item in collection)
            //{
            //    if (!predicate(item))
            //    {
            //        list.Add(item);
            //    }
            //}
            //return list;
        }

        public static TSelector Max<TSource, TSelector> (this IEnumerable<TSource> collection, Func<TSource, TSelector> predicate) 
            where TSelector: IComparable
        {
            if (collection == null)
            {
                throw new ArgumentNullException("Collection is empty.");
            }

            TSelector max = predicate(collection.First());

            foreach (var source in collection)
            {
                if (max.CompareTo(predicate(source)) < 0)
                {
                    max = predicate(source);
                }
            }
            return max;
        }
    }
}
