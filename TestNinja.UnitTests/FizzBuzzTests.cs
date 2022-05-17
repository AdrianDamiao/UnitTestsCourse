using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(0)]
        [TestCase(-15)]
        [TestCase(60)]
        public void GetOutput_WhenNumberIsDivisibleByThreeAndFive_ReturnFizzBuzz(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        [TestCase(3)]
        [TestCase(-6)]
        [TestCase(21)]
        public void GetOutput_WhenNumberIsDivisibleByThree_ReturnFizz(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        [TestCase(5)]
        [TestCase(25)]
        [TestCase(-10)]
        public void GetOutput_WhenNumberIsDivisibleByFive_ReturnBuzz(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        [TestCase(2)]
        [TestCase(1)]
        [TestCase(-98)]
        public void GetOutput_WhenNumberIsNotDivisibleByThreeOrFive_ReturnNumber(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo(number.ToString()));
        }
    }
}
