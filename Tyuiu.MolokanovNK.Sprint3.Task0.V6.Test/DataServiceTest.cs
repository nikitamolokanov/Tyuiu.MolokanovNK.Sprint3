using Tyuiu.MolokanovNK.Sprint3.Task0.V6.Lib;

namespace Tyuiu.MolokanovNK.Sprint3.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 15;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            double wait = 67.88;

            Assert.AreEqual(res, wait);
        }
    }
}
