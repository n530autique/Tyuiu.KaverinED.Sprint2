using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaverinED.Sprint2.Task1.V9.Lib;
namespace Tyuiu.KaverinED.Sprint2.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int a = 15, b = 335, c = 174, d = 478;
            bool[] exp = { false, false, true, false, true, false };
            DataService ds = new DataService();
            CollectionAssert.AreEqual(exp, ds.GetLogicOperations(a, b, c, d));
        }
    }
}
