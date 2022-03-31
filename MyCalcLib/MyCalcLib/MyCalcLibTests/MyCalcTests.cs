using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalcLib;
using System;

namespace MyCalcLibTests
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            int a = 6; int b = 24; int c = 72;
            MyCalc x = new MyCalc();
            int actual = x.Nod(a,b,c);
            int expected = 6;
            Assert.AreEqual(actual, expected);
        }
    }
}
