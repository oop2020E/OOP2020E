using KG09Exercises.factoryVersion;
using System;
using System.Collections;
using System.Collections.Generic;

namespace KG09Exercises
{
    namespace solutions
    {
        

        public class RandomNumbers : IEnumerable<int>
        {

            private class RandomNumberEnumerator : BaseEnumerator
            {
                private int min;
                private int max;
                private Random random;

                public RandomNumberEnumerator(int min, int max, int seed)
                {
                    if (seed != -1)
                        this.random = new Random(seed);
                    else this.random = new Random();

                    this.min = min;
                    this.max = max;
                }

                protected override int GetNext()
                {
                    if (min == -1 && max == -1)
                        return random.Next();
                    else return random.Next(min, max);
                }
            }
            public RandomNumbers(int min, int max, int seed) : this(seed)
            {
                Min = min;
                Max = max;
            }
            public int Max { get; } = -1;
            public int Min { get; } = -1;
            public int Seed { get; } = -1;

            public RandomNumbers(int seed)
            {
                Seed = seed;
            }
            public RandomNumbers()
            {

            }

            public IEnumerator<int> GetEnumerator()
            {
                return new RandomNumberEnumerator(Min, Max, Seed);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }


        }
    }

}
