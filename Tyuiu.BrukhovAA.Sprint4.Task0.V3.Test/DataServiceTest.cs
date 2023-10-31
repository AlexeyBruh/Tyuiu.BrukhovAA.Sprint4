using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BrukhovAA.Sprint4.Task0.V3.Lib;

namespace Tyuiu.BrukhovAA.Sprint4.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultOddArrEl()
        {
            DataService ds = new DataService();

            int[] array = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };

            int res = ds.GetMultOddArrEl(array);

            int wait = 945;

            Assert.AreEqual(wait, res);
        }
    }
}
