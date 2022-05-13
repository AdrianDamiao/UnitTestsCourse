using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TestNinja.Fundamentals;
using Assert = NUnit.Framework.Assert;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        private HtmlFormatter _htmlFormatterTests;

        [SetUp]
        public void SetUp()
        {
            _htmlFormatterTests = new HtmlFormatter();
        }

        [Test]
        public void HtmlFormatter_WhenCalled_ReturnsTheTextAsBold()
        {
            var result = _htmlFormatterTests.FormatAsBold("Some Text");

            Assert.That(result, Is.EqualTo("<strong>Some Text</strong>").IgnoreCase);
        }
    }
}
