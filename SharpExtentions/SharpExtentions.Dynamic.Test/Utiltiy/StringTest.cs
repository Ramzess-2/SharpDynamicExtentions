using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpExtentions.Dynamic.Utility;

namespace SharpExtentions.Dynamic.Test.Utiltiy {

    [TestClass]
    public class StringTest {

        [TestMethod]
        public void TestEmailString() {
            
            Assert.IsTrue("ravillion@mail.ru".isEmail());
            Assert.IsTrue("ravillion@mail.ru.com".isEmail());
            Assert.IsTrue("ravillion@123.com".isEmail());
            Assert.IsTrue("ravillion@mail-123.com".isEmail());
            
            Assert.IsFalse("ra(vill)ion@mail.r.com".isEmail());
            Assert.IsFalse("ra(vill)ion@mail.ru".isEmail());
            Assert.IsFalse("ra(vill)ion@mail.r".isEmail());

        }

        [TestMethod]
        public void TestDomainString() {
            Assert.IsTrue("mail.ru".isDomain());
            Assert.IsTrue("mail.ru.com".isDomain());
        }

        [TestMethod]
        public void Base64Test() {
            
            Assert.AreEqual("ZGxmamxkamdsamRsZ2pkbGZqZw==", "dlfjldjgljdlgjdlfjg".toBase64());
            Assert.AreEqual("dlfjldjgljdlgjdlfjg", "ZGxmamxkamdsamRsZ2pkbGZqZw==".fromBase64());

        }



    }
}