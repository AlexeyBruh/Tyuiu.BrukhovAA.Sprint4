using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BrukhovAA.Sprint4.Task2.V1.Lib;

namespace Tyuiu.BrukhovAA.Sprint4.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] array = new int[] { 6, 7, 8, 7, 6, 5, 6, 8, 4, 2};

            int res = ds.Calculate(array);

            int wait = 110592;

            Assert.AreEqual(wait, res);
        }
    }
}
