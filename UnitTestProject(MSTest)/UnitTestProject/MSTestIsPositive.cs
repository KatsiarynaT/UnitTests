using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class MSTestIsPositive
    {
        public CSharpCalculator.Calculator testCalc;

        [TestInitialize]
        public void MSTestInitialize()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        public void MSTestIsPositiveIntTrue()
        {
            int positiveNumber = 62;
            bool expectedResult = true;
            bool actualResult = testCalc.isPositive(positiveNumber);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestIsPositiveIntFalse()
        {
            int negativeNumber = -36;
            bool expectedResult = false;
            bool actualResult = testCalc.isPositive(negativeNumber);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestIsPositiveDouble()
        {
            double Number = 16.9;
            bool expectedResult = true;
            bool actualResult = testCalc.isPositive(Number);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestIsPositiveString()
        {
            string Number = "-15";
            bool expectedResult = false;
            bool actualResult = testCalc.isPositive(Number);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCleanup]
        public void MSTestCleanup()
        {
            testCalc = null;
        }
    }
}

