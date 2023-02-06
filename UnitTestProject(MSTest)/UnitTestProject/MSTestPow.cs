using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class MSTestPow
    {
        public CSharpCalculator.Calculator testCalc;

        [TestInitialize]
        public void MSTestInitialize()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        public void MSTestPowInt()
        {
            int firstNumber = 14;
            int secondNumber = 2;
            int expectedResult = 196;
            double actualResult = testCalc.Pow(firstNumber, secondNumber);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestPowDouble()
        {
            double firstNumber = 6.25;
            double secondNumber = 0.5;
            double expectedResult = 2.5;
            double actualResult = testCalc.Pow(firstNumber, secondNumber);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestPowString()
        {
            string firstNumber = "3";
            string secondNumber = "7";
            string expectedResult = "2187";
            double actualResult = testCalc.Pow(firstNumber, secondNumber);
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult);
        }

        [TestMethod]
        public void MSTestPowZero()
        {
            int firstNumber = 150;
            int secondNumber = 0;
            int expectedResult = 1;
            double actualResult = testCalc.Pow(firstNumber, secondNumber);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCleanup]
        public void MSTestCleanup()
        {
            testCalc = null;
        }
    }
}

