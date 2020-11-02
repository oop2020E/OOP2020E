using System;
using System.Collections.Generic;

namespace KG07Exercises
{

    #region Exercise 1
    public delegate string StringJoin(string s1, string s2);

    #endregion

    public partial class ExerciseClass
    {
        #region Exercise 2

        public string Join3(string s1, string s2, string s3, StringJoin f) => f(s1, f(s2, s3));
        #endregion

        public string JoinAllStrings(List<string> l, StringJoin f) => JoinAllStrings(l, f, 0);
        private string JoinAllStrings(List<string> l, StringJoin f, int startIndex) => JoinAll(l, ( v1,  v2)=>f(v1, v2), startIndex);
/***        after completing exercise 4, we replace this
        { 

        if (l.Count == 0 || l.Count <= startIndex)
            throw new ArgumentException("Invalid startindex or no elements in list");
        if (l.Count - startIndex == 1)
            return l[startIndex];
        else return f(l[startIndex], JoinAllStrings(l, f, startIndex + 1));
        } 
**/

}

    #region Exercise 4
    public delegate T Join<T>(T v1, T v2);
    public partial class ExerciseClass
    {
        public T JoinAll<T>(List<T> l, Join<T> f) => JoinAll(l, f, 0);

        private T JoinAll<T>(List<T> l, Join<T> f, int startIndex)
        {
            if (l.Count == 0 || l.Count <= startIndex)
                throw new ArgumentException("Invalid startindex or no elements in list");
            if (l.Count - startIndex == 1)
                return l[startIndex];
            else return f(l[startIndex], JoinAll(l, f, startIndex + 1));
        }

        #region Exercise 5

        public bool Exists<T>(Predicate<T> f, T[] a)
        {
            foreach (var item in a)
            {
                if (f(item))
                    return true;
            }
            return false;
        }
        #endregion

        #region Exercise 6
        public T Twice<T>(Func<T, T> f, T v) => f(f(v));
        #endregion
    }
    #endregion

}
