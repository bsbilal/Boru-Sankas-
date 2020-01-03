using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestChars
{
    [TestClass]
    public class TestCharacters
    {
        [TestMethod]
        public void TestText()
        {
            BoruSankasi.DecideString Karar = new BoruSankasi.DecideString();
            bool sonuc = Karar.TextControl("Hangisidir");
            Assert.AreEqual(true, sonuc);
        }
        [TestMethod]
        public void TestNumber()
        {
            BoruSankasi.DecideString Karar = new BoruSankasi.DecideString();
            bool sonuc = Karar.TextControl("5455");
            Assert.AreEqual(true, sonuc);
        }
        [TestMethod]
        public void TestQuestionMark()
        {
            BoruSankasi.DecideString Karar = new BoruSankasi.DecideString();
            bool sonuc = Karar.TextControl("?");
            Assert.AreEqual(true, sonuc);
        }
    }
}
