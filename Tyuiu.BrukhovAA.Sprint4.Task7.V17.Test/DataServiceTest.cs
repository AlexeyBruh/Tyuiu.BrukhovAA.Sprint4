using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BrukhovAA.Sprint4.Task7.V17.Lib;

namespace Tyuiu.BrukhovAA.Sprint4.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            string str = "753159864";
            int rows = 3;
            int columns = 3;

            int[,] mtrx = new int[rows, columns];

            int res = ds.Calculate(rows, columns, str);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
