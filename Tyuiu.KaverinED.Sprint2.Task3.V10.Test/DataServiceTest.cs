using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaverinED.Sprint2.Task3.V10.Lib;
namespace Tyuiu.KaverinED.Sprint2.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(0);
            Assert.AreEqual(res, -1);
        }
    }
}
