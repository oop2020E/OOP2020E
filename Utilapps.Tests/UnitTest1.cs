using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Utilapps.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [DataRow(1,2,3)]
        [DataRow(2,2,4)]
        [DataTestMethod]
        public void TestAdd(int a, int b, int expected)
        {
            Calculator c = new Calculator();
            var result = c.Add(a, b);

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void Add_TwoAndTwo_returnFour()
        {
            Calculator c = new Calculator();
            int inputa = 5;
            int inputb = 5;
            int expected = 4;

            void f()
            {
                c.Add(inputb, inputa);
            }

            //int result = c.Add(inputa, inputb);
            Assert.ThrowsException<Exception>(f);
            //Assert.AreEqual(expected, c.Add(inputa, inputb));
        }
    }
}
