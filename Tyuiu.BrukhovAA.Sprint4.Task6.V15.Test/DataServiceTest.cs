﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BrukhovAA.Sprint4.Task6.V15.Lib;

namespace Tyuiu.BrukhovAA.Sprint4.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            string[] mass = new string[] { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };

            int res = ds.Calculate(mass);

            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}
