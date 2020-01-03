using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestQuestionClassImagePath
{
    [TestClass]
    public class BosSoruResimTesti
    {
        [TestMethod]
        public void GetEmptyValue()
        {
            BoruSankasi.Question Soru = new BoruSankasi.Question();

            Assert.AreEqual("-", Soru.m_ImagePath.ToString());
        }
        [TestMethod]
        public void GetEmptyValueSecond()
        {
            BoruSankasi.Question Soru = new BoruSankasi.Question();

            string BaseImage = "https://image.shutterstock.com/image-vector/no-image-available-vector-illustration-600w-744886198.jpg";


            Assert.AreEqual(BaseImage, Soru.m_ImagePath.ToString());
        }
    }
}
