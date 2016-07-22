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
    }
}
