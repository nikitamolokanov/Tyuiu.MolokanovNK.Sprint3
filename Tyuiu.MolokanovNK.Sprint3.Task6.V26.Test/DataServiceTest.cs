using Tyuiu.MolokanovNK.Sprint3.Task6.V26.Lib;

namespace Tyuiu.MolokanovNK.Sprint3.Task6.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 15;
            int stopValue = 22;

            double res = ds.GetSumTheDivisors(startValue, stopValue);

            double wait = 242;

            Assert.AreEqual(res, wait);
        }
    }
}
