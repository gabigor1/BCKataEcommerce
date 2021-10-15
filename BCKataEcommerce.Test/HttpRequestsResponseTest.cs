using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using BCKataEcommerce;
using BCKataEcommerce.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace BCKataEcommerce.Test
{
    public class HttpRequestResponseTests
    {
        [Fact]
        public void Get_AllProducts()
        {
            // Arrange
            var controller = new ProductsController();
            // Act
            var response = controller.Get();
            // Assert
            var okResult = Assert.IsType<OkObjectResult>(response);
            var returnValue = Assert.IsType<List<Product>>(okResult.Value);
            returnValue.Count().Should().Be(3);
        }

    [Theory]
    [InlineData("Apple", 1)]
    [InlineData("aubergine", 3)]
    public void Get_ProductsByName(string name, int expectedId)
    {
        // Arrange
        var controller = new ProductsController();
        // Act
        var response = controller.GetByName(name);
        // Assert
        var okResult = Assert.IsType<OkObjectResult>(response);
        var returnValue = Assert.IsType<Product>(okResult.Value);
        returnValue.Id.Should().Be(expectedId);
    }

    [Theory]
    [InlineData("fruit", 2)]
    [InlineData("vegetable", 1)]
    [InlineData("fruit, yellow", 1)]
    public void Get_ProductsByTags(string tags, int expectedCount)
    {
        // Arrange
        var controller = new ProductsController();
        // Act
        var response = controller.GetByTags(tags);
        // Assert
        var okResult = Assert.IsType<OkObjectResult>(response);
        var returnValue = Assert.IsType<List<Product>>(okResult.Value);
            returnValue.Count.Should().Be(expectedCount);
    }
    }
}