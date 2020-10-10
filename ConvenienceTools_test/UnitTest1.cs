using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConvenienceTools;
using System.Reflection.PortableExecutable;

namespace ConvenienceTools_test
{
    [TestClass]
    public class Rng_test
    {
        [TestMethod]
        public void BasicFunctionality()
        {
            Assert.AreEqual("0123".rng(1, 3), "12");
        }

        [TestMethod]
        public void Negative1End()
        {
            Assert.AreEqual("0123".rng(0, -1), "0123");
        }

        [TestMethod]
        public void BothBeyondRange()
        {
            Assert.AreEqual("0123".rng(-10, 90), "0123");
        }

        [TestMethod]
        public void StartBiggerThanLength()
        {
            Assert.AreEqual("0123".rng(90, 2), "");
            Assert.AreEqual("0123".rng(90, -1), "");
            Assert.AreEqual("0123".rng(90, 4), "");
            Assert.AreEqual("0123".rng(90, 10), "");
        }

        [TestMethod]
        public void EmptyString()
        {
            Assert.AreEqual("0123".rng(0, 0), "");
            Assert.AreEqual("0123".rng(3, 3), "");
            Assert.AreEqual("".rng(0, 0), "");
            Assert.AreEqual("".rng(0, 9), "");
        }

        [TestMethod]
        public void CrossedBoundaries()
        {
            Assert.AreEqual("0123".rng(3,1), "");
        }

        [TestMethod]
        public void StartEqualsEnd()
        {
            Assert.AreEqual("0123".rng(2, 2), "");
        }
    }
}
