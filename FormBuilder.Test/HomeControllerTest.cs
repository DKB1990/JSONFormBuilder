using Microsoft.AspNetCore.Mvc;
using FormBuilder.Controllers;
using System;
using System.Threading.Tasks;
using Xunit;

namespace FormBuilder.FormBuilder.Test
{
    public class HomeControllerTest
    {
        [Fact]
        public void TestView_Get_Index()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            Assert.Equal("Index", result.ViewName);
        }
    }
}
