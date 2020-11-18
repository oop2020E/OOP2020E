using System;
using System.Collections.Generic;

namespace KG09Exercises.factoryVersion
{
    class MinMaxEnumeratorFactory : IEnumeratorFactory
    {
        public MinMaxEnumeratorFactory( int min, int max)
        {
            Max = max;
            Min = min;
        }
        public int Max { get;  }
        public int Min { get; }

        public IEnumerator<int> GetEnumerator()
        {
            return new MinMaxEnumerator(Min, Max);
        }

        private class MinMaxEnumerator : BaseEnumerator
        {
            private int min;
            private int max;
            Random r = new Random();

            public MinMaxEnumerator(int min, int max)
            {
                this.min = min;
                this.max = max;
                r = new Random();
            }

            protected override int GetNext()
            {
                return r.Next(min, max);
            }
        }
    }

    
}
