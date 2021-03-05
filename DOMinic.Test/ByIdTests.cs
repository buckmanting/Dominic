using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace DOMinic.Test
{
    public class ByIdTests
    {
        public ByIdTests()
        {
            var currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            var viewPath = $"{currentDirectory}/TestTemplates";
            Template.SetViewLocation(viewPath);
        }

        [Fact]
        public async Task ItCanGetById()
        {
            var sut = await Template.Render("MultipleUniqueIds.cshtml", new {TestText = "Hello World"});
            Assert.Equal("My Div One, Hello World", sut.GetOnlyById("div-1").Value);
        }

        [Fact]
        public async Task ItThrowsAnErrorWhenMoreThanOneElementFound()
        {
            var sut = await Template.Render("MultipleDuplicateIds.cshtml", new {TestText = "Hello World"});
            Assert.Throws<InvalidOperationException>(() => sut.GetOnlyById("div-1"));
        }

        [Fact]
        public async Task ItReturnsNullWhenNoElementFound()
        {
            var sut = await Template.Render("MultipleUniqueIds.cshtml", new {TestText = "Hello World"});
            Assert.Null(sut.GetOnlyById("not-a-real-id"));
        }
    }
}