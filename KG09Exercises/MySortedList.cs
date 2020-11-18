using System;
using System.Collections;
using System.Collections.Generic;

namespace KG09Exercises
{
    class MySortedList<T> :ICollection<T> where T : IComparable<T>
    {
        List<T> data = new List<T>();
        public T this[int index]
        {
            get => data[index];
        }

        public int Count => data.Count;

        public bool IsReadOnly => ((ICollection<T>)data).IsReadOnly;

        public void Add(T item)
        {
            data.Add(item);
            data.Sort(); // you could also use insertion sort and perhaps a linkedlist as data...
        }

        public void Clear() => data.Clear();

        public bool Contains(T item) => data.Contains(item);

        public void CopyTo(T[] array, int arrayIndex) => data.CopyTo(array, arrayIndex);

        public IEnumerator<T> GetEnumerator() =>  data.GetEnumerator();

        public bool Remove(T item) => data.Remove(item);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public IEnumerator<T> GetElementsReversed()
        {
            return new ReverseEnumerator(data);
        }

        private class ReverseEnumerator : IEnumerator<T>
        {
            private List<T> data;
            private int index;

            public ReverseEnumerator(List<T> data)
            {
                this.data = data;
                Reset();
            }

            public T Current => data[index];

            object IEnumerator.Current => Current;

            public void Dispose() { }

            public bool MoveNext()
            {
                return 0 > --index;
            }

            public void Reset()
            {
                index = data.Count;
            }
        }
    }


}
