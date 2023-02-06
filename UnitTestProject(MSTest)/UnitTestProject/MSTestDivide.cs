using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class MSTestDivide
    {
        public CSharpCalculator.Calculator testCalc;

        [TestInitialize]
        public void MSTestInitialize()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        public void MSTestDivideInt()
        {
            int firstNumber = 50;
            int secondNumber = 5;
            int expectedResult = 10;
            double actualResult = testCalc.Divide(firstNumber, secondNumber);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestDivideDouble()
        {
            double firstNumber = 30.3;
            double secondNumber = 1.5;
            double expectedResult = 20.2;
            double actualResult = testCalc.Divide(firstNumber, secondNumber);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestDivideString()
        {
            string firstNumber = "28";
            string secondNumber = "7";
            string expectedResult = "4";
            double actualResult = testCalc.Divide(Convert.ToDouble(firstNumber), Convert.ToDouble(secondNumber));
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult);
        }

        [TestMethod]
        public void MSTestDivideZero()
        {
            int firstNumber = 50;
            int secondNumber = 0;
            double actualResult = testCalc.Divide(firstNumber, secondNumber);
        }

        [TestCleanup]
        public void MSTestCleanup()
        {
            testCalc = null;
        }
    }
}