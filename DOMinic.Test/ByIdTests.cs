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
        public async Task ItCanDoGood()
        {
            var sut = await Template.Render("Article.cshtml", new
            {
                Title = "A cool title",
                Author = "Hello World"
            });
            // can i get this to ignore empty attributes
            Assert.Equal(true, (bool)sut.GetOnlyById("my-button").Attribute("disabled"));
        }

        // [Fact]
        // public async Task ItCanWithComplexClasses()
        // {
        //     var sut = await Template.Render("ComplexClasses.cshtml", new {TestText = "Hello World"});
        //     var expectedClasses = new[]
        //     {
        //         "cool-class-a",
        //         "another-class",
        //         "col-12"
        //     };
        //     Assert.Equal(expectedClasses, sut.GetOnlyById("a-lot-of-classes").Attribute("class"));
        // }

        [Fact]
        public async Task ItThrowsAnErrorWhenMoreThanOneElementFound()
        {
            var sut = await Template.Render("MultipleDuplicateIds.cshtml", new {TestText = "Hello World"});
            Assert.Throws<InvalidOperationException>(() =>
                sut.GetOnlyById("div-1")); // should this be a more explicit error?
        }

        [Fact]
        public async Task ItReturnsNullWhenNoElementFound()
        {
            var sut = await Template.Render("MultipleUniqueIds.cshtml", new {TestText = "Hello World"});
            Assert.Null(sut.GetOnlyById("not-a-real-id"));
        }
    }
}