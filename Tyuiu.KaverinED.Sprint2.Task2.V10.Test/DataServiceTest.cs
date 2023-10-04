using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaverinED.Sprint2.Task2.V10.Lib;
namespace Tyuiu.KaverinED.Sprint2.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int x = 5, y = 8;
            DataService ds = new DataService();
            Assert.AreEqual(ds.CheckDotInShadedArea(x, y), true);
        }
    }
}
