using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDateTime
{
    [TestClass]
    public class TestDates
    {
        [TestMethod]
        public void TestDateBig()
        {
            BoruSankasi.GetDataDifference DateTester = new BoruSankasi.GetDataDifference();
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = dt1.AddHours(24).AddMinutes(25).AddSeconds(00);

            TimeSpan dif = DateTester.getDateDifference(dt1,dt2);
            int differenceInDays = dif.Days;
            Assert.AreEqual(1, differenceInDays);

        }
        [TestMethod]
        public void TestDateSmall()
        {
            BoruSankasi.GetDataDifference DateTester = new BoruSankasi.GetDataDifference();
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = dt1.AddHours(24).AddMinutes(25).AddSeconds(00);

            TimeSpan dif = DateTester.getDateDifference(dt1, dt2);
            int differenceInDays = dif.Days;
            Assert.AreEqual(-1, differenceInDays);

        }

    }
}
