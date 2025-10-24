﻿using Tyuiu.MolokanovNK.Sprint3.Task4.V24.Lib;

namespace Tyuiu.MolokanovNK.Sprint3.Task4.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

         
            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 4.477;

            Assert.AreEqual(res, wait);
        }
    }
}
