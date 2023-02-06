namespace UnitTest_NUnit_
{
    public class NUnitAdd
    {
        public CSharpCalculator.Calculator testCalc;

        [SetUp]
        public void NUnitSetup()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [TestCase(19, 6, 25)]
        [TestCase(-8, -6, -14)]
        public void NUnitAddInt(int firstNumber, int secondNumber, int expectedResult)
        {
            double actualResult = testCalc.Add(firstNumber, secondNumber);
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [TestCase(9.2, 6.3, 15.5)]
        [TestCase(-81.6, 1.3, -80.3)]
        public void NUnitAddDouble(double firstNumber, double secondNumber, double expectedResult)
        {
            double actualResult = testCalc.Add(firstNumber, secondNumber);
            Assert.That(actualResult, Is.EqualTo(expectedResult).Within(0.1));
        }

        [TestCase("91", "5", "96")]
        [TestCase("-8", "-61", "-69")]
        public void NUnitAddString(string firstNumber, string secondNumber, string expectedResult)
        {
            double actualResult = testCalc.Add(firstNumber, secondNumber);
            Assert.That(actualResult, Is.EqualTo(Convert.ToDouble(expectedResult)));
        }

        [TearDown]
        public void NUnitTearDown()
        {
            testCalc = null;
        }
    }
}