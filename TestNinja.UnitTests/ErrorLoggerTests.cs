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
    public class ErrorLoggerTests
    {
        private ErrorLogger _logger;

        [SetUp]
        public void SetUp()
        {
            _logger = new ErrorLogger();
        }

        [Test]
        public void Log_WhenCalled_SetLastErrorProperty()
        {
            _logger.LastError = "Error";

            Assert.That(_logger.LastError, Is.EqualTo("Error"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            // _logger.Log(error) - Will throw an exception

            Assert.That(() => _logger.Log(error), Throws.ArgumentNullException);
            // Assert.That(() => _logger.Log(error), Throws.Exception.TypeOf<CustomException>()); - For Custom Exceptions
        }
    }
}
