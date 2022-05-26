using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServicesTests
    {
        [Test]
        public void ReadVideoTitle_FileIsEmpty_ReturnErrorMessage()
        {
            var videoService = new VideoService(new FakeFileReader());
             
            var result = videoService.ReadVideoTitle();

            Assert.That(result, Does.Contain("Error").IgnoreCase);
        }
    }
}
