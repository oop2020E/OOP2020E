using System;
using System.Collections.Generic;
using System.Linq;

namespace LiveCode
{



    class TreeNode<TValue> where TValue : IComparable<TValue>
    {
        public List<TValue> Value { get; set; }

        public TreeNode<TValue> Left { get; set; }
        public TreeNode<TValue> Right { get; set; }

        public void AddChild(TValue value)
        {
            // ... 

        }
    }


    class Methods
    {
        public void Init<T>(T[] arr, T initialValue)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = initialValue;
            }
        }

        public T Max<T>(IEnumerable<T> ts) where T : IComparable<T>
        {
            T result = default;
            if (ts.Count() == 0)
                return result;
            else 
                result = ts.First();

            foreach (T item in ts)
            {
                if (item.CompareTo(result) > 0)
                    result = item;
            }
            return result;
        }

        void foo()
        {
            Pair<int, string> p1 = new Pair<int, string>(10, "Thomas");
            List<Pair<Pair<int,string>, int>> pairs = new List<Pair<Pair<int, string>, int>>();
            Pair<int, string> v = pairs[0].First;




            Pair<string, int> v2 = new Pair<string, int>(default, default);

            
        }

    }

    class Pair<TFst, TSnd> where TFst : class, new()
    {
        public Pair(TFst first, TSnd second)
        {
            First = first;
            TFst asf = new TFst();
            Second = second;
        }
         



        public TFst First { get; }
        public TSnd Second { get; }

        public Pair<TSnd, TFst> Swap() // opgave: hvorfor får vi compilefejl? hint: TFst-constaint
        {
            return new Pair<TSnd, TFst>(Second, First);
        }
        public Pair<TFst, TNew> ReplaceSnd<TNew>(TNew val) where TNew : TFst
        {
            return new Pair<TFst, TNew>(First, val);
        }
    }
}