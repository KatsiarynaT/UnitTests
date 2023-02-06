using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class MSTestSin
    {
        public CSharpCalculator.Calculator testCalc;

        [TestInitialize]
        public void MSTestInitialize()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        public void MSTestSinInt()
        {
            int Number = 0;
            int expectedResult = 0;
            double actualResult = testCalc.Sin(Number);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestSinDouble()
        {
            double Number = 1.2;
            double expectedResult = 0.932;
            double actualResult = testCalc.Sin(Number);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }

        [TestMethod]
        public void MSTestSinString()
        {
            string Number = "1.5708";
            string expectedResult = "1";
            double actualResult = testCalc.Sin(Number);
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult, 0.1);
        }

        [TestCleanup]
        public void MSTestCleanup()
        {
            testCalc = null;
        }
    }
}