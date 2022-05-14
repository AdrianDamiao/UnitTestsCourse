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
    public class CustomerControllerTests
    {
        private CustomerController _customerController;

        [SetUp]
        public void SetUp()
        {
            _customerController = new CustomerController();
        }

        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var result = _customerController.GetCustomer(0);
            
            // Only NotFound
            //Assert.That(result, Is.TypeOf<NotFound>());

            // NotFound and derivatives
            //Assert.That(result, Is.InstanceOf<NotFound>());

            Assert.That(result.GetType(), Is.EqualTo(typeof(NotFound)));
        }
    }
}
