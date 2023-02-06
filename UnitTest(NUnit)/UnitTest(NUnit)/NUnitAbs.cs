namespace UnitTest_NUnit_
{
    public class NUnitAbs
    {
        public CSharpCalculator.Calculator testCalc;

        [SetUp]
        public void NUnitSetup()
        {
            testCalc = new CSharpCalculator.Calculator();
        }

        [TestCase(115, 115)]
        [TestCase(-84, 84)]
        public void NUnitAbsInt(int Number, int expectedResult)
        {
            double actualResult = testCalc.Abs(Number);
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [TestCase(9.2, 9.2)]
        [TestCase(-81.6, 81.6)]
        public void NUnitAbsDouble(double Number, double expectedResult)
        {
            double actualResult = testCalc.Abs(Number);
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [TestCase("91", "91")]
        [TestCase("-8", "8")]
        public void NUnitAbsString(string Number, string expectedResult)
        {
            double actualResult = testCalc.Abs(Number);
            Assert.That(actualResult, Is.EqualTo(Convert.ToDouble(expectedResult)));
        }

        [TearDown]
        public void NUnitTearDown()
        {
            testCalc = null;
        }
    }
}