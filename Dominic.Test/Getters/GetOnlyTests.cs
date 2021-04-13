using System.IO;
using System.Threading.Tasks;

using Dominic.Exceptions;
using Xunit;

namespace Dominic.Test
{
    public class GetOnlyTests
    {
        public GetOnlyTests()
        {
            var currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            var viewPath = $"{currentDirectory}/TestTemplates";
            Template.SetViewLocation(viewPath);
        }

        [Fact]
        public async Task ById_ItCanGet()
        {
            var sut = await Template.Render("MultipleUniqueIds.cshtml", new {TestText = "Hello World"},
                "Dominic.Tests.TestTemplates");
            Assert.Equal("My Div One, Hello World", sut.GetOnly.ById("div-1").InnerText);
        }

        [Fact]
        public async Task ById_ItThrowsAnErrorWhenMoreThanOneElementFound()
        {
            var sut = await Template.Render("MultipleDuplicateIds.cshtml", new {TestText = "Hello World"},
                "Dominic.Tests.TestTemplates");
            Assert.Throws<TooManyElementsFoundException>(() => sut.GetOnly.ById("div-1"));
        }

        [Fact]
        public async Task ById_ItReturnsNullWhenNoElementFound()
        {
            var sut = await Template.Render("MultipleUniqueIds.cshtml", new {TestText = "Hello World"},
                "Dominic.Tests.TestTemplates");
            Assert.Null(sut.GetOnly.ById("not-a-real-id"));
        }

        [Fact]
        public async Task ByTestId_ItCanGet()
        {
            var sut = await Template.Render("Article.cshtml", new {Title = "A cool title", Author = "Aaron Buckley"},
                "Dominic.Tests.TestTemplates");
            Assert.Equal("Written by Aaron Buckley", sut.GetOnly.ByTestId("cool-test-id").InnerText);
        }

        [Fact]
        public async Task ByTestId_ItThrowsAnErrorWhenMoreThanOneElementFound()
        {
            var sut = await Template.Render("MultipleDuplicateIds.cshtml", new {TestText = "Hello World"},
                "Dominic.Tests.TestTemplates");
            Assert.Throws<TooManyElementsFoundException>(() => sut.GetOnly.ByTestId("my-test-id"));
        }

        [Fact]
        public async Task ByTestId_ItReturnsNullWhenNoElementFound()
        {
            var sut = await Template.Render("MultipleUniqueIds.cshtml", new {TestText = "Hello World"},
                "Dominic.Tests.TestTemplates");
            Assert.Null(sut.GetOnly.ByTestId("not-a-real-id"));
        }

        [Fact]
        public async Task ByType_ItCanGet()
        {
            var sut = await Template.Render("Article.cshtml", new {Title = "A cool title", Author = "Aaron Buckley"},
                "Dominic.Tests.TestTemplates");
            Assert.Equal("A cool title", sut.GetOnly.ByType("h2").InnerText);
        }

        [Fact]
        public async Task ByType_ItThrowsAnErrorWhenMoreThanOneElementFound()
        {
            var sut = await Template.Render("MultipleDuplicateIds.cshtml", new {TestText = "Hello World"},
                "Dominic.Tests.TestTemplates");
            Assert.Throws<TooManyElementsFoundException>(() => sut.GetOnly.ByType("div"));
        }

        [Fact]
        public async Task ByType_ItReturnsNullWhenNoElementFound()
        {
            var sut = await Template.Render("MultipleUniqueIds.cshtml", new {TestText = "Hello World"},
                "Dominic.Tests.TestTemplates");
            Assert.Null(sut.GetOnly.ByType("not-real"));
        }

        [Fact]
        public async Task ByPartialName_ItCanGet()
        {
            var sut = await Template.Render("Article.cshtml", new {Title = "A cool title", Author = "Aaron Buckley"},
                "Dominic.Tests.TestTemplates");
            Assert.NotNull(sut.GetOnly.ByPartialName("_PartialName.cshtml"));
        }

        [Fact]
        public async Task ByPartialName_ItThrowsAnErrorWhenMoreThanOneElementFound()
        {
            var sut = await Template.Render("MultipleDuplicateIds.cshtml", new {TestText = "Hello World"},
                "Dominic.Tests.TestTemplates");
            Assert.Throws<TooManyElementsFoundException>(() => sut.GetOnly.ByPartialName("common-partial"));
        }

        [Fact]
        public async Task ByPartialName_ItReturnsNullWhenNoElementFound()
        {
            var sut = await Template.Render("MultipleUniqueIds.cshtml", new {TestText = "Hello World"},
                "Dominic.Tests.TestTemplates");
            Assert.Null(sut.GetOnly.ByPartialName("not-real"));
        }

        //[Fact]
        //public async Task ItCanDoAnotherGood()
        //{
        //    var sut = await Template.Render("Article.cshtml", new
        //    {
        //        Title = "<div>title</div>",
        //        Author = "Aaron > Arron < Aaron"
        //    });
        //    // can i get this to ignore empty attributes
        //    Assert.Equal(true, (bool)sut.GetOnlyById("my-button").Attribute("disabled"));
        //}

        // [Fact]
        // public async Task ItCanWithComplexClasses()
        // {
        //     var sut = await Template.Render("ComplexClasses.cshtml", new {TestText = "Hello World"}, "Dominic.Tests.TestTemplates");
        //     var expectedClasses = new[]
        //     {
        //         "cool-class-a",
        //         "another-class",
        //         "col-12"
        //     };
        //     Assert.Equal(expectedClasses, sut.GetOnlyById("a-lot-of-classes").Attribute("class"));
        // }
    }
}