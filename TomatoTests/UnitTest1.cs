using System;
using TomatoPizzaCafe.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace TomatoTests
{
    public class HomeControllerTests
    {
        public HomeControllerTests()
        {
        }

        [Fact]
        public void Index_should_return_default_view()
        {
            var controller = new HomeController();
            var viewResult = (ViewResult)controller.Index();
            var viewName = viewResult.ViewName;

            Assert.True(string.IsNullOrEmpty(viewName) || viewName == "Index");
        }
    }

    public class MakeYourOwnControllerTests
    {
        public MakeYourOwnControllerTests()
        {
        }

        [Fact]
        public void Index_should_return_default_view()
        {
            var controller = new HomeController();
            var viewResult = (ViewResult)controller.Index();
            var viewName = viewResult.ViewName;

            Assert.True(string.IsNullOrEmpty(viewName) || viewName == "Index");
        }
    }

    public class OrdersControllerTests
    {
        public OrdersControllerTests()
        {
        }

        [Fact]
        public void Index_should_return_default_view()
        {
            var controller = new HomeController();
            var viewResult = (ViewResult)controller.Index();
            var viewName = viewResult.ViewName;

            Assert.True(string.IsNullOrEmpty(viewName) || viewName == "Index");
        }
    }

    public class PizzasControllerTests
    {
        public PizzasControllerTests()
        {
        }

        [Fact]
        public void Index_should_return_default_view()
        {
            var controller = new HomeController();
            var viewResult = (ViewResult)controller.Index();
            var viewName = viewResult.ViewName;

            Assert.True(string.IsNullOrEmpty(viewName) || viewName == "Index");
        }
    }

    public class ToppingsControllerTests
    {
        public ToppingsControllerTests()
        {
        }

        [Fact]
        public void Index_should_return_default_view()
        {
            var controller = new HomeController();
            var viewResult = (ViewResult)controller.Index();
            var viewName = viewResult.ViewName;

            Assert.True(string.IsNullOrEmpty(viewName) || viewName == "Index");
        }
    }
}
