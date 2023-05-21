using System;
using Xunit;
using xunitExample.Controllers;
using System.Text;
using System.Collections.Generic;


namespace xunitExample.Tests.Controllers
{
    public class HomeControllerTest
    {
        [Fact]
        public void HomeController_Index_ValidResult()
        {
            HomeController controller = new HomeController();
            string expectedResult1 = "I am learning DevOps";
            string expectedResult2 = "DevOps is being learnt by me";
            string result = controller.Index();
            Assert.Equal(expectedResult1,result);
            Assert.Equal(expectedResult2, result);
        }
    }
}
