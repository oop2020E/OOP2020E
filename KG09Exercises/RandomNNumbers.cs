using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace KG09Exercises.factoryVersion
{
    class RandomNNumbers : IEnumerable<int>
    {
        FactoryBasedRandomNumbers implementation;
        private readonly int n;

        public RandomNNumbers(int n, int min, int max, int seed)
        {
            this.implementation = new FactoryBasedRandomNumbers(min, max, seed);
            this.n = n;
        }
        public RandomNNumbers(int n,int seed)
        {
            this.implementation = new FactoryBasedRandomNumbers(seed);
            this.n = n;
        }
        public RandomNNumbers(int n)
        {
            implementation = new FactoryBasedRandomNumbers();
            this.n = n;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return implementation.Take(n).GetEnumerator(); 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


}
