using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaverinED.Sprint2.Task4.V18.Lib;

namespace Tyuiu.KaverinED.Sprint2.Task4.V18.Test
{
    [TestClass]
    public class DataServIceTest
    {
        [TestMethod]
        public void ValiedExpression()
        {
            DataService ds = new DataService();
            double x = 1, y = 5;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(50, res);
        }
    }
}
