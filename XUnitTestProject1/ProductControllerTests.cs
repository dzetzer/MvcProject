using System;
using System.Collections.Generic;
using System.Text;
using NSubstitute;
using Microsoft.AspNetCore.Mvc;
using MvcProject.Controllers;
using MvcProject.Models;
using MvcProject.Repositories;
using Xunit;
using System.Linq;

namespace MvcProject.Tests
{
    public class ProductControllerTests
    {

        ProductController underTest;
        IRepository<Product> productRepo;

        public ProductControllerTests()
        {
            productRepo = Substitute.For<IRepository<Product>>();
            underTest = new ProductController(productRepo);
        }
        [Fact]
        public void Index_Returns_View_Result()
        {     

          var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_All_Products_To_View()
        {
            var expectedProducts = new List<Product>();
            productRepo.GetAll().Returns(expectedProducts);

            var result = underTest.Index();

            Assert.Equal(expectedProducts, result.Model);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            var result = underTest.Details(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Returns_Second_View()
        {
            var result = underTest.Details(2);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Passes_Product_To_View()
        {
            var expectedProducts = new Product();
            productRepo.GetByID(1).Returns(expectedProducts);

            var result = underTest.Details(1);

            Assert.Equal(expectedProducts, result.Model);
        }

    }
}
