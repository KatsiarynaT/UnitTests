using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class MSTestAdd
    {
        public CSharpCalculator.Calculator testCalc;

        [TestInitialize]
        public void MSTestInitialize()
        {
           testCalc= new CSharpCalculator.Calculator();
        }

        [TestMethod]
        public void MSTestAddInt()
        {
            int firstNumber = 8;
            int secondNumber = 6;
            int expectedResult = 14;
            double actualResult = testCalc.Add(firstNumber, secondNumber);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestAddDouble()
        {
            double firstNumber = 4.7;
            double secondNumber = 5.1;
            double expectedResult = 9.8;
            double actualResult = testCalc.Add(firstNumber, secondNumber);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MSTestAddString()
        {
            string firstNumber = "25";
            string secondNumber = "9";
            string expectedResult = "34";
            double actualResult = testCalc.Add(firstNumber, secondNumber);
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult);
        }

        [TestCleanup]
        public void MSTestCleanup()
        {
            testCalc=null;
        }
    }
}
