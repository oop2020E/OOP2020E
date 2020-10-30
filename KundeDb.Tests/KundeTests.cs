using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;

namespace KundeDb.Tests
{

    interface IFoo
    {
        bool IsCorrect();
    }

    class Hest
    {
        public bool Vrinsk(IFoo foo)
        {
            return foo.IsCorrect();
        }
    }

    [TestClass]
    public class KundeTests
    {
        [TestMethod]
        public void SetName_InvalidFormat_CausesArgumentException()
        {
            Kunde k = new Kunde();
            void foo() => k.Name = null;
            Assert.ThrowsException<ArgumentException>(foo);
        }
    }
}
