using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;

namespace KundeDb.Tests
{



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
