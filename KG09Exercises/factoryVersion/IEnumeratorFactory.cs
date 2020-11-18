using System.Collections.Generic;

namespace KG09Exercises.factoryVersion
{
    interface IEnumeratorFactory
    {
        IEnumerator<int> GetEnumerator();
    }

}
