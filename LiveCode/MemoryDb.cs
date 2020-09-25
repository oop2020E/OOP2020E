using System;

namespace LiveCode
{
    class MemoryDb : IPersonDb
    {
        public void Insert(Person p)
        {
            throw new OutOfMemoryException();
        }
    }
}