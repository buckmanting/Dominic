using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Localization;
using Moq;
using Xunit;

namespace Dominic.Test
{
    public class DIResolverTests
    {
        public DIResolverTests()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var viewPath = $"{currentDirectory}/Views/TestView";
            Template.SetViewLocation(viewPath);
        }

        [Fact]
        public async Task ItSupportsResolvingInjectedTypes()
        {
            Template.SetResolver((Type memberType) =>
            {
                if (memberType.Name == "IViewLocalizer")
                {
                    return new Mock<IViewLocalizer>().Object;
                }

                return new object();
            });
            var sut = await Template.Render("_localisation.cshtml", new {TestText = "Hello World"});
            Assert.NotNull(sut.GetOnly.ById("username"));
        }
    }
}