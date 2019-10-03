using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using MvcProject.Controllers;
using Xunit;

namespace MvcProject.Tests
{
    public class ProductControllerTests
    {
        [Fact]
        public void Index_Returns_View_Result()
        {
            var underTest = new ProductController();

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
