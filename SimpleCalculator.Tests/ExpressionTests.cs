using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTests
    {
        [TestMethod]
        public void isNotNull()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            Expression testObj = new Expression("1+1", dic);
            Assert.IsNotNull(testObj);
        }
        [TestMethod]
        public void returnsArray()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            Expression testObj = new Expression("1+1", dic);
            Assert.IsInstanceOfType(testObj.getArray(), typeof(string[]));
        }
        [TestMethod]
        public void areThingsInPlace()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            Expression testObj = new Expression("1+6", dic);
            Assert.IsTrue(testObj.getArray()[1] == "1");
            Assert.IsTrue(testObj.getArray()[2] == "+");
            Assert.IsTrue(testObj.getArray()[3] == "6");
        }
        [TestMethod]
        public void isntCorrect()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            Expression testObj = new Expression("+2", dic);
            Assert.IsFalse(testObj.getArray()[0] == "true");
        }
        [TestMethod]
        public void dicVarTest()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("a", "5");
            Expression testObj = new Expression("a+2", dic);
            Assert.IsTrue(testObj.getArray()[1] == "5");
        }
        [TestMethod]
        public void ableToPutVarInDicAKAHowDoesThisWork()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            Expression testObj = new Expression("a=2", dic);
            Assert.IsTrue(dic["a"] == "2");
        }
        [TestMethod]
        public void needsAnEqualsSign()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            Expression testObj = new Expression("a-2", dic);
            Assert.IsTrue(testObj.getArray()[0] == "false");
        }
    }
}
