using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hola.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var p = new Default();
            Assert.AreEqual(1, p.suma(1, 1));
        }
    }
}
