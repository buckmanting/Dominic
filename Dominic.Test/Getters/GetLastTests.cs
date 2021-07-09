using System.IO;
using System.Threading.Tasks;
using Dominic.Exceptions;
using Xunit;

namespace Dominic.Test.Getters
{
    public class GetLastTests
    {
        private DominicConfiguration _configuration;

        public GetLastTests()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var viewPath = $"{currentDirectory}/Views/TestView";
            _configuration = new DominicConfiguration { ViewFolderLocation = viewPath };
        }

        [Fact]
        public async Task ById_ItCanGet()
        {
            var sut = await Template.Render(
                "MultipleDuplicateIds.cshtml",
                _configuration,
                new { TestText = "Hello World" });
            Assert.Equal("My Div Four, Hello World", sut.GetLast.ById("div-1").InnerText);
        }

        [Fact]
        public async Task ById_ItReturnsNullWhenNoElementFound()
        {
            var sut = await Template.Render(
                "MultipleUniqueIds.cshtml",
                _configuration,
                new { TestText = "Hello World" });
            Assert.Null(sut.GetLast.ById("not-a-real-id"));
        }

        [Fact]
        public async Task ByTestId_ItCanGet()
        {
            var sut = await Template.Render(
                "Article.cshtml",
                _configuration,
                new { Title = "A cool title", Author = "Aaron Buckley" });
            Assert.Equal("A last Paragraph", sut.GetLast.ByTestId("cool-test-id").InnerText);
        }

        [Fact]
        public async Task ByTestId_ItReturnsNullWhenNoElementFound()
        {
            var sut = await Template.Render(
                "MultipleUniqueIds.cshtml",
                _configuration,
                new { TestText = "Hello World" });
            Assert.Null(sut.GetLast.ByTestId("not-a-real-id"));
        }

        [Fact]
        public async Task ByType_ItCanGet()
        {
            var sut = await Template.Render(
                "Article.cshtml",
                _configuration,
                new { Title = "A cool title", Author = "Aaron Buckley" });
            Assert.Equal("Next title", sut.GetLast.ByType("h2").InnerText);
        }

        [Fact]
        public async Task ByType_ItReturnsNullWhenNoElementFound()
        {
            var sut = await Template.Render(
                "MultipleUniqueIds.cshtml",
                _configuration,
                new { TestText = "Hello World" });
            Assert.Null(sut.GetLast.ByType("not-real"));
        }

        [Fact]
        public async Task ByPartialName_ItCanGet()
        {
            var sut = await Template.Render(
                "Article.cshtml",
                _configuration,
                new { Title = "A cool title", Author = "Aaron Buckley" });
            Assert.NotNull(sut.GetLast.ByPartialName("_PartialName.cshtml"));
        }

        [Fact]
        public async Task ByPartialName_ItReturnsNullWhenNoElementFound()
        {
            var sut = await Template.Render(
                "MultipleUniqueIds.cshtml",
                _configuration,
                new { TestText = "Hello World" });
            Assert.Null(sut.GetLast.ByPartialName("not-real"));
        }

        [Fact]
        public async Task ItCanWithComplexClasses()
        {
            var sut = await Template.Render(
                "ComplexClasses.cshtml",
                _configuration,
                new { TestText = "Hello World" }
            );
            var expectedClasses = new[]
            {
                "cool-class-a",
                "another-class",
                "col-12"
            };
            Assert.Equal(expectedClasses, sut.GetLast.ById("a-lot-of-classes").Classes);
        }
    }
}