namespace UnitTest_NUnit_
{
    public class NUnitSub
    {
        public CSharpCalculator.Calculator testCalc;

        [SetUp]
        public void NUnitSetup()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [TestCase(9, 6, 3)]
        [TestCase(-8, -6, -2)]
        public void NUnitSubInt(int firstNumber, int secondNumber, int expectedResult)
        {
            double actualResult = testCalc.Sub(firstNumber, secondNumber);
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [TestCase(9.2, 6.3, 2.9)]
        [TestCase(-81.6, 1.3, -82.9)]
        public void NUnitSubDouble(double firstNumber, double secondNumber, double expectedResult)
        {
            double actualResult = testCalc.Sub(firstNumber, secondNumber);
            Assert.That(actualResult, Is.EqualTo(expectedResult).Within(0.1));
        }

        [TestCase("9", "6", "3")]
        [TestCase("-8", "-6", "-2")]
        public void NUnitSubString(string firstNumber, string secondNumber, string expectedResult)
        {
            double actualResult = testCalc.Sub(firstNumber, secondNumber);
            Assert.That(actualResult, Is.EqualTo(Convert.ToDouble(expectedResult)));
        }

        [TearDown]
        public void NUnitTearDown() 
        {
            testCalc = null;
        }
    }
}