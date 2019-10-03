using System;
using Microsoft.AspNetCore.Mvc;
using MvcProject.Controllers;
using Xunit;

namespace MvcProject.Tests
{
    public class MvcProjectTests
    {
        [Fact]
        public void Index_Returns_View_Result()
        {
            var underTest = new HomeController();

            var result = underTest.Index();

            Assert.IsType <ViewResult> (result);
        }

        [Fact] 
        public void Home_Index_Linked_To_Product_Index()
        {

        }

    }
}
