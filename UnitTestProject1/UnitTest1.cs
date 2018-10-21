using System;
using kata40;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestsEscaped()
        {
            Assert.AreEqual("Escaped!", Program.CatMouse("C....m"));
        }

        [TestMethod]
        public void TestsCaught()
        {
            Assert.AreEqual("Caught!", Program.CatMouse("C..m"));
        }
    }
}
