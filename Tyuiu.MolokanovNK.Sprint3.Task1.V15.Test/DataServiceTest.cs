using Tyuiu.MolokanovNK.Sprint3.Task1.V15.Lib;

namespace Tyuiu.MolokanovNK.Sprint3.Task1.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 2;
            int startValue = 1;
            int stopValue = 5;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 208845;

            Assert.AreEqual(res, wait);
        }
    }
}
