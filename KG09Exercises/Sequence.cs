using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KG09Exercises
{
    namespace solutions
    {
        #region Exercise1

        public class Sequence : IEnumerable<int>
        {


            public Sequence(int start, int count=-1, int skip=1)
            {
                Start = start;
                Count = count;
                Skip = skip;
            }
            public int Start { get; }
            public int Count { get; } 
            public int Skip { get; }
            public IEnumerator<int> GetEnumerator()
            {
                return new SequenceEnumerator(Start, Count, Skip);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            private class SequenceEnumerator : IEnumerator<int>
            {
                private int count;
                private int skip;

                public SequenceEnumerator(int start, int count, int skip)
                {
                    Current = start-skip; // we start just before current
                    this.count = count;
                    this.skip = skip;
                }

                public int Current { get; private set; }

                object IEnumerator.Current => Current;

                public void Dispose()
                {                    
                }

                public bool MoveNext()
                {
                    Current += skip;
                    return count-- > 0;
                }

                public void Reset()
                {
                    throw new NotImplementedException(); // reset to original values
                }
            }
        }

#endregion
    }

}
