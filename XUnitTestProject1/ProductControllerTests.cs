using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using MvcProject.Controllers;
using MvcProject.Models;
using MvcProject.Repositories;
using Xunit;

namespace MvcProject.Tests
{
    public class ProductControllerTests
    {
        IRepository<Product> productRepo;

        [Fact]
        public void Index_Returns_View_Result()
        {
            var underTest = new ProductController(productRepo);

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_GreetingModel_To_View()
        {
            var controller = new ProductController(productRepo);

            var result = controller.Index();

            Assert.IsType<Product>(result.Model);
        }
    }
}
