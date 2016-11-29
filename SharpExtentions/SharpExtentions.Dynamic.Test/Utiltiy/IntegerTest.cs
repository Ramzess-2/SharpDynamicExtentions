using SharpExtentions.Dynamic.Utility;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SharpExtentions.Dynamic.Test.Utiltiy
{
    [TestClass]
    public class IntegerTest {

        [TestMethod]
        public void FactorialTest() {
            Assert.AreEqual(8.Factorial(), 40320);
            Assert.AreEqual(9.Factorial(), 362880);
        }

        [TestMethod]
        public void SimpleDigitTest() {
            
            Assert.IsTrue(2.IsPrime());
            Assert.IsTrue(3.IsPrime());
            Assert.IsTrue(5.IsPrime());
            Assert.IsTrue(7.IsPrime());
            Assert.IsTrue(11.IsPrime());
            Assert.IsTrue(13.IsPrime());
            Assert.IsTrue(17.IsPrime());
            Assert.IsTrue(19.IsPrime());
            Assert.IsTrue(23.IsPrime());
            Assert.IsTrue(29.IsPrime());
            Assert.IsTrue(31.IsPrime());
            Assert.IsTrue(37.IsPrime());
            Assert.IsTrue(41.IsPrime());
            Assert.IsTrue(43.IsPrime());
            Assert.IsTrue(47.IsPrime());

            Assert.IsFalse(12.IsPrime());
            Assert.IsFalse(15.IsPrime());
            Assert.IsFalse(42.IsPrime());
            Assert.IsFalse(177.IsPrime());
            Assert.IsFalse(606.IsPrime());
            Assert.IsFalse(649.IsPrime());
            

        }

    }
}
