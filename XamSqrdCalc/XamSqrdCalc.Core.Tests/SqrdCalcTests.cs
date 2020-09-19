using NUnit.Framework;
using XamSqrdCalc.Core.Services;

namespace XamSqrdCalc.Core.Tests
{
    [TestFixture]
    public class SqrdCalcTests
    {
        private ISquareRootCal calc;

        [SetUp]
        public void Setup()
        {
            //Arrange
            calc = new SquareRootCalc();
        }

        [Test]
        public void Calculate_9_returns_3()
        {
            //Act
            var squareRoot = calc.Calculate(9);
            //Assert
            Assert.AreEqual(3,squareRoot);
        }
    }
}