using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class MathsTest
    {
        [TestMethod]
        public void addition()
        {
            Maths addition = new Maths(5, "+", 5);
            Assert.AreEqual(addition.Answer(), 10);
        }
        [TestMethod]
        public void subtraction()
        {
            Maths addition = new Maths(5, "-", 5);
            Assert.AreEqual(addition.Answer(), 0);
        }
        [TestMethod]
        public void multiplicion()
        {
            Maths addition = new Maths(5, "*", 5);
            Assert.AreEqual(addition.Answer(), 25);
        }
        [TestMethod]
        public void division()
        {
            Maths addition = new Maths(5, "/", 5);
            Assert.AreEqual(addition.Answer(), 1);
        }
        [TestMethod]
        public void isNum()
        {
            Maths addition = new Maths(1, "+", 1);
            Assert.IsInstanceOfType(addition.Answer(), typeof(int));
        }
    }
}
