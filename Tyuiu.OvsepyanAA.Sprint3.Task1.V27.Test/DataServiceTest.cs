using Tyuiu.OvsepyanAA.Sprint3.Task1.V27.Lib;

namespace Tyuiu.OvsepyanAA.Sprint3.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.75;
            int startvalue = 1;
            int stopvalue = 5;

            double res = ds.GetMultiplySeries(value, startvalue, stopvalue);

            double wait = 419028.1;

            Assert.AreEqual(res, wait);
        }
    }
}