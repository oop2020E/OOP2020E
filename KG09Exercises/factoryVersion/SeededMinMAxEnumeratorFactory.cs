using System;
using System.Collections.Generic;

namespace KG09Exercises.factoryVersion
{
    class SeededMinMAxEnumeratorFactory : IEnumeratorFactory
    {
        int min;
        int max;
        int seed;
        public SeededMinMAxEnumeratorFactory(int min, int max, int seed) 
        {
            this.min = min;
            this.max = max;
            this.seed = seed;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new SeededMinMAxEnumerator(min,max,seed);
        }

        private class SeededMinMAxEnumerator : BaseEnumerator
        {
            private int min;
            private int max;
            Random r;

            public SeededMinMAxEnumerator(int min, int max, int seed)
            {
                this.min = min;
                this.max = max;
                r = new Random(seed);
            }

            protected override int GetNext()
            {
                return r.Next(min, max);
            }
        }
    }


}
