using Tyuiu.ZaharovVV.Sprint2.Task2.V13.Lib;

namespace Tyuiu.ZaharovVV.Sprint2.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int y = 6;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool waight = true;
            Assert.AreEqual(true, res);
        }
    }
}