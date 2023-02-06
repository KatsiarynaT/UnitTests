using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class MSTestSub
    {
        public CSharpCalculator.Calculator testCalc;

        [TestInitialize]
        public void MSTestInitialize()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        public void MSTestSubInt()
        {
            int firstNumber = 9;
            int secondNumber = 6;
            int expectedResult = 3;
            double actualResult = testCalc.Sub(firstNumber, secondNumber);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestSubDouble()
        {
            double firstNumber = 5.6;
            double secondNumber = 3.2;
            double expectedResult = 2.4;
            double actualResult = testCalc.Sub(firstNumber, secondNumber);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestSubString()
        {
            string firstNumber = "13";
            string secondNumber = "2";
            string expectedResult = "11";
            double actualResult = testCalc.Sub(firstNumber, secondNumber);
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult);
        }

        [TestCleanup]
        public void MSTestCleanup()
        {
            testCalc = null;
        }
    }
}
