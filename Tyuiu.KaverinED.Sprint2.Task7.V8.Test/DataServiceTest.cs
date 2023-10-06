using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaverinED.Sprint2.Task7.V8.Lib;
namespace Tyuiu.KaverinED.Sprint2.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 1, y1 = 2;
            double x2 = 1, y2 = 1;
            double x3 = 1, y3 = 0.5;
            bool[] result =
            {
                ds.CheckDotInShadedArea(x1, y1),
                ds.CheckDotInShadedArea(x2, y2),
                ds.CheckDotInShadedArea(x3, y3)
            };
            bool[] expect =
            {
                false,
                false,
                true
            };

            CollectionAssert.AreEqual(result, expect);
        }
    }
}
