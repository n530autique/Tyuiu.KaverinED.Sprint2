using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaverinED.Sprint2.Task0.V1.Lib;
namespace Tyuiu.KaverinED.Sprint2.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int x = 233, y = 122;
            bool[] expect = { false, true, false, true, false, true };
            DataService ds = new DataService();
            CollectionAssert.AreEqual(ds.GetCompareOperations(x, y), expect);
        }
    }
}
