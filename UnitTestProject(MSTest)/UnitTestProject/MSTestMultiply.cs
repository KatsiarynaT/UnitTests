using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class MSTestMultiply
    {
        public CSharpCalculator.Calculator testCalc;

        [TestInitialize]
        public void MSTestInitialize()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        public void MSTestMultiplyInt()
        {
            int firstNumber = 2;
            int secondNumber = -5;
            int expectedResult = -10;
            double actualResult = testCalc.Multiply(firstNumber, secondNumber);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestMultiplyDouble()
        {
            double firstNumber = 20.2;
            double secondNumber = 1.5;
            double expectedResult = 30.3;
            double actualResult = testCalc.Multiply(firstNumber, secondNumber);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestMultiplyString()
        {
            string firstNumber = "4";
            string secondNumber = "7";
            string expectedResult = "28";
            double actualResult = testCalc.Multiply(Convert.ToDouble(firstNumber), Convert.ToDouble(secondNumber));
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult);
        }

        [TestMethod]
        public void MSTestMultiplyZero()
        {
            int firstNumber = 50;
            int secondNumber = 0;
            int expectedResult = 0;
            double actualResult = testCalc.Multiply(firstNumber, secondNumber);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCleanup]
        public void MSTestCleanup()
        {
            testCalc = null;
        }
    }
}
