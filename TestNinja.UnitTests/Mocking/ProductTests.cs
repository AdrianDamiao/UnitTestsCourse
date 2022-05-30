using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{   
    [TestFixture]
    public class ProductTests
    {
        private Product _product;

        [SetUp]
        public void SetUp()
        {
            _product = new Product() { ListPrice = 100 };
        }

        [Test] // Com Mock -- X
        public void GetPrice_GoldCustomer_Apply30PercentDiscount()
        {
            var customer = new Mock<ICustomer>();
            customer.Setup(c => c.IsGold).Returns(true);

            var result = _product.GetPrice(customer.Object);

            Assert.That(result, Is.EqualTo(70));
        }

        // [Test]
        // public void GetPrice_GoldCustomer_Apply30PercentDiscount() Sem Mock
        // {
        //    var result = _product.GetPrice(new Customer() { IsGold = true });

        //    Assert.That(result, Is.EqualTo(70));
        // }
    }
}
