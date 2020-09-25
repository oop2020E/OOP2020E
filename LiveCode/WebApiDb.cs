using System;

namespace LiveCode
{
    class WebApiDb : IPersonDb
    {
        public void Insert(Person p)
        {
            throw new TimeoutException();
        }
    }
}