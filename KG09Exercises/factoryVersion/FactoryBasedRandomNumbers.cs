using System.Collections.Generic;
using System.Collections;
using System.Runtime.CompilerServices;
using KG09Exercises.solutions;
using System.Linq;

namespace KG09Exercises.factoryVersion
{


    public class FactoryBasedRandomNumbers : IEnumerable<int>
    {
        IEnumeratorFactory enumeratorFactory;

        public FactoryBasedRandomNumbers(int min, int max, int seed) 
        {
            enumeratorFactory = new SeededMinMAxEnumeratorFactory(min, max, seed);
        }
        public FactoryBasedRandomNumbers(int seed)
        {
            enumeratorFactory = new SeededEnumeratorFactory(seed);
        }
        public FactoryBasedRandomNumbers()
        {
            enumeratorFactory = new SimpleEnumeratorFactory();
        }

        public IEnumerator<int> GetEnumerator()
        {
            return enumeratorFactory.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class SimpleEnumeratorFactory : IEnumeratorFactory
        {
            public IEnumerator<int> GetEnumerator()
            {
                return new RandomNumbers().GetEnumerator();
            }
        }
    }


}
