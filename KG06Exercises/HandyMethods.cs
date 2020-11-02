using System;
using System.Collections.Generic;

namespace KG06Exercises
{
    #region Exercise 1
    public class HandyMethods
    {
        #region 1a
        public T Max<T>(List<T> l) where T : IComparable<T>
        {
            if (l.Count == 0)
                throw new ArgumentException("No max element of an empty list");
            T result = l[0];
            foreach (var item in l)
            {
                if (result.CompareTo(item) < 0)
                    result = item;
            }
            return result;
        }
        public T Min<T>(List<T> l) where T : IComparable<T>
        {
            if (l.Count == 0)
                throw new ArgumentException("No min element of an empty list");
            T result = l[0];
            foreach (var item in l)
            {
                if (result.CompareTo(item) > 0)
                    result = item;
            }
            return result;
        }
        #endregion
        #region 1b
        public void Copy<T>(T[] source, T[] destination)
        {
            if (source.Length != destination.Length)
                throw new ArgumentException("Arrays have unequal lengths");
            for (int i = 0; i < source.Length; i++)
            {
                destination[i] = source[i];
            }
        }
        #endregion
        #region 1c
        // samme mønster som 1a og 1b
        #endregion
    }
    #endregion

}
