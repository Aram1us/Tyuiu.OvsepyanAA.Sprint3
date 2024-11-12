using Tyuiu.OvsepyanAA.Sprint3.Task0.V14.Lib;

namespace Tyuiu.OvsepyanAA.Sprint3.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int value = 2;
            int startValue = 1;
            int stopValue = 5;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 14400;
            Assert.AreEqual(wait, res);
        }
    }
}