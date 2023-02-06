using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class MSTestSqrt
    {
        public CSharpCalculator.Calculator testCalc;

        [TestInitialize]
        public void MSTestInitialize()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        public void MSTestSqrtInt()
        {
            int Number = 36;
            int expectedResult = 6;
            double actualResult = testCalc.Sqrt(Number);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestSqrtDouble()
        {
            double Number = 0.36;
            double expectedResult = 0.6;
            double actualResult = testCalc.Sqrt(Number);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestSqrtString()
        {
            string Number = "49";
            string expectedResult = "7";
            double actualResult = testCalc.Sqrt(Number);
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult);
        }

        [TestCleanup]
        public void MSTestCleanup()
        {
            testCalc = null;
        }
    }
}


