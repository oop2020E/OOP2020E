using System.Collections.Generic;
using System.Collections;

namespace KG09Exercises.factoryVersion
{


    abstract class BaseEnumerator : IEnumerator<int>
        {
            protected abstract int GetNext();
            public int Current { get; protected set; }
            object IEnumerator.Current => Current;


            public void Dispose() { }

            public bool MoveNext()
            {
                Current = GetNext();
                return true;
            }

            public void Reset()
            { } // reset
        }

}
