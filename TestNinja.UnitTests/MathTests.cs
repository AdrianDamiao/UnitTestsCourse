
using System;
using NUnit.Framework;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        //[Ignore("Porque eu quis!")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            // Act
            var result = _math.Add(1, 2);

            // Assert
            //Assert.That(result, Is.EqualTo(3));
            Assert.That(_math, Is.Not.Null); // Teste não confiável, algo que sempre vai passar
        }

        // Teste Parametrizado
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            // Act
            var result = _math.Max(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreatherThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);
            
            // Assert.That(result, Is.Not.Null); // Too general
            // Assert.That(result.Count(), Is.EqualTo(3)); Too specific

            // Assert.That(result, Does.Contain(1));
            // Assert.That(result, Does.Contain(3));
            // Assert.That(result, Does.Contain(5));

            // More polite way
            Assert.That(result, Is.EquivalentTo(new [] {1, 3, 5})); // Regardless of the order in which they are

            // Assert.That(result, Is.Ordered); Verify if the list is ordered
            // Assert.That(result, Is.Unique); Verify if the list does not contain repeated numbers
        }

        [Test]
        public void GetOddNumbers_LimitIsEqualToZero_ReturnEmptyList()
        {
            var result = _math.GetOddNumbers(0);

            Assert.That(result, Is.EquivalentTo(new int[]{}));
        }

        [Test]
        public void GetOddNumbers_LimitIsLessThanZero_ReturnEmptyList()
        {
            var result = _math.GetOddNumbers(-5);

            Assert.That(result, Is.EquivalentTo(new int[]{}));
        }
    }
}
