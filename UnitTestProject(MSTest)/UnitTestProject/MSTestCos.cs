using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class MSTestCos
    {
        public CSharpCalculator.Calculator testCalc;

        [TestInitialize]
        public void MSTestInitialize()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        public void MSTestCosInt()
        {
            int Number = 0;
            int expectedResult = 1;
            double actualResult = testCalc.Cos(Number);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestCosDouble()
        {
            double Number = 1.0472;
            double expectedResult = 0.5;
            double actualResult = testCalc.Cos(Number);
            Assert.AreEqual(expectedResult, actualResult, 0.1);
        }

        [TestMethod]
        public void MSTestCosString()
        {
            string Number = "1.0472";
            string expectedResult = "0.5";
            double actualResult = testCalc.Cos(Number);
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult, 0.1);
        }

        [TestCleanup]
        public void MSTestCleanup()
        {
            testCalc = null;
        }
    }
}