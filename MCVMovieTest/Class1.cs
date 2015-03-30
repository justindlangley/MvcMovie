using MvcMovie.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Xunit;

namespace MCVMovieTest
{
    public class Class1
    {
        [Fact]

        public void SomeTest()
        {

            var controller = new HelloWorldController();
            var someView = controller.Welcome("", 1);
            Assert.NotNull(someView);
            
            var theView = (ViewResult)someView;
            Assert.NotNull(theView);
            
        }

    }
}
