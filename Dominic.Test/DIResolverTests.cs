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
        [Fact]
        public async Task ItSupportsResolvingInjectedTypes()
        {
            // Arragne
            var currentDirectory = Directory.GetCurrentDirectory();
            var viewPath = $"{currentDirectory}/Views/TestView";

            Func<Type, object> resolver = (Type memberType) =>
            {
                if (memberType.Name == "IViewLocalizer")
                {
                    return new Mock<IViewLocalizer>().Object;
                }

                return new object();
            };

            // Act
            var configuration = new DominicConfiguration {ViewFolderLocation = viewPath, Resolver = resolver};
            
            // Assert
            var sut = await Template.Render("_localisation.cshtml", configuration,new {TestText = "Hello World"});
            Assert.NotNull(sut.GetOnly.ById("username"));
        }
    }
}