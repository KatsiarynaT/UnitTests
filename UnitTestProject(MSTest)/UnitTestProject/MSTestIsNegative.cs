using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class MSTestIsNegative
    {
        public CSharpCalculator.Calculator testCalc;

        [TestInitialize]
        public void MSTestInitialize()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        public void MSTestIsNegativeIntTrue()
        {
            int negativeNumber = -2;
            bool expectedResult = true;
            bool actualResult = testCalc.isNegative(negativeNumber);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestIsNegativeIntFalse()
        {
            int positiveNumber = 36;
            bool expectedResult = false;
            bool actualResult = testCalc.isNegative(positiveNumber);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestIsNegativeDouble()
        {
            double Number = 25.3;
            bool expectedResult = false;
            bool actualResult = testCalc.isNegative(Number);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestIsNegativeString()
        {
            string Number = "-15";
            bool expectedResult = true;
            bool actualResult = testCalc.isNegative(Number);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCleanup]
        public void MSTestCleanup()
        {
            testCalc = null;
        }
    }
}
