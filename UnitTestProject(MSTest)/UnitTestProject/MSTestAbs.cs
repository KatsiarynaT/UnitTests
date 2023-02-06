using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class MSTestAbs
    {
        public CSharpCalculator.Calculator testCalc;

        [TestInitialize]
        public void MSTestInitialize()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        public void MSTestAbsPositiveInt()
        {
            int positiveNumber = 15;
            int expectedResult = 15;
            double actualResult = testCalc.Abs(positiveNumber);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestAbsNegativeInt()
        {
            int negativeNumber = -36;
            int expectedResult = 36;
            double actualResult = testCalc.Abs(negativeNumber);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestAbsPositiveDouble()
        {
            double positiveNumber = 9.9;
            double expectedResult = 9.9;
            double actualResult = testCalc.Abs(positiveNumber);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestAbsNegativeDouble()
        {
            double negativeNumber = -3.6;
            double expectedResult = 3.6;
            double actualResult = testCalc.Abs(negativeNumber);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestAbsPositiveString()
        {
            string positiveNumber = "25";
            string expectedResult = "25";
            double actualResult = testCalc.Abs(positiveNumber);
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult);
        }

        [TestMethod]
        public void MSTestAbsNegativeString()
        {
            string negativeNumber = "-9";
            string expectedResult = "9";
            double actualResult = testCalc.Abs(negativeNumber);
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult);
        }

        [TestCleanup]
        public void MSTestCleanup()
        {
            testCalc = null;
        }
    }
}
