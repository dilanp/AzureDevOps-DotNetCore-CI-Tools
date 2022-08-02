using CodeQuality.Models;
using Xunit;

namespace UnitTests
{
    public class CustomerTests
    {
        [Fact]
        public void Customer_Creation_SetsName()
        {
            var customer = new Customer(1, "Mark");

            Assert.Equal(1, customer.Id);
            Assert.Equal("Mark", customer.Name);
        }
    }
}