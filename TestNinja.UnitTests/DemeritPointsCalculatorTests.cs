using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _demeritPointsCalculator;

        [SetUp]
        public void SetUp()
        {
            _demeritPointsCalculator = new DemeritPointsCalculator();
        }

        [Test]
        [TestCase(-10)]
        [TestCase(350)]
        public void CalculateDemeritPoints_SpeedIsOutOfRange_ReturnArgumentOutOfRangeException(int speed)
        {
            Assert.That(() => _demeritPointsCalculator.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(40)]
        [TestCase(65)]
        [TestCase(25)]
        public void CalculateDemeritPoints_SpeedIsEqualOrLessThanSpeedLimit_ReturnZero(int speed)
        {
            var result = _demeritPointsCalculator.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCase(100, 7)]
        [TestCase(120, 11)]
        [TestCase(84, 3)]
        public void CalculateDemeritPoint_WhenCalled_ReturnDemeritPoints(int speed, int expectedDemeritPoints)
        {
            var result = _demeritPointsCalculator.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo(expectedDemeritPoints));
        }
    }
}
