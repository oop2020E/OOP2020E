using System;

namespace LiveCode
{
    class DiskDb : IPersonDb
    {
        public void Insert(Person p)
        {
            throw new AccessViolationException();
        }
    }
}