using System;
using Microsoft.AspNetCore.Mvc;
using MvcProject.Controllers;
using Xunit;

namespace MvcProject.Tests
{
    public class MvcProjectTests
    {
        [Fact]
        public void Index_Returns_Hello_World()
        {
            var underTest = new HomeController();

            var result = underTest.Index();

            Assert.IsType <ViewResult> (result);
        }

    }
}
