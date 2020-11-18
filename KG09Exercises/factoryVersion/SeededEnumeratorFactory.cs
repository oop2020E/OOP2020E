using System;
using System.Collections.Generic;

namespace KG09Exercises.factoryVersion
{

    class SeededEnumeratorFactory : IEnumeratorFactory
    {
        private int seed;

        public SeededEnumeratorFactory(int seed)
        {
            this.seed = seed;
        }
        public IEnumerator<int> GetEnumerator()
        {
            return new SeededEnumerator(seed);
        }

        public class SeededEnumerator : BaseEnumerator
        {
            protected Random r;

            public SeededEnumerator(int seed)
            {
                r = new Random(seed);

            }

            protected override int GetNext()
            {
                return r.Next();
            }
        }
    }

    

}
