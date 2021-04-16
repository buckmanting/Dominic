using System;
using System.IO;
using System.Threading.Tasks;
using Moq;
using Xunit;

namespace Dominic.Test
{
    using Microsoft.AspNetCore.Mvc.Localization;

    public class DIResolverTests
    {
        public DIResolverTests()
        {
            var currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            var viewPath = $"{currentDirectory}/TestTemplates";
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