using System;
using Xunit;
using BCKataEcommerce;
using BCKataEcommerce.Controllers;

namespace BCKataEcommerce.Test
{
    public class HttpRequestResponse
    {
        [Fact]
        public void Get_AllProducts()
        {
            // Arrange
            var controller = new ProductsController();
            // Act
            var response = controller.Get();
            // Assert
            Assert.NotNull(response);
        }

        [Theory]
        [InlineData("Apple")]
        [InlineData("aubergine")]
        public void Get_ProductsByName(string name)
        {
            // Arrange
            var controller = new ProductsController();
            // Act
            var response = controller.GetByName(name);
            // Assert
            Assert.NotNull(response);
        }
    }
}