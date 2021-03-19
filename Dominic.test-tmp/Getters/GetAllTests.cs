using Dominic.Exceptions;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace Dominic.Test
{
    public class GetAllTests
    {
        public GetAllTests()
        {
            var currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            var viewPath = $"{currentDirectory}/TestTemplates";
            Template.SetViewLocation(viewPath);
        }

        [Fact]
        public async Task ById_ItCanGet()
        {
            var sut = await Template.Render("MultipleDuplicateIds.cshtml", new { TestText = "Hello World" });

            Assert.Equal(4, sut.GetAll.ById("div-1").Count);
        }

        [Fact]
        public async Task ById_ItReturnsNullWhenNoElementFound()
        {
            var sut = await Template.Render("MultipleUniqueIds.cshtml", new { TestText = "Hello World" });
            Assert.Empty(sut.GetAll.ById("not-a-real-id"));
        }

        [Fact]
        public async Task ByTestId_ItCanGet()
        {
            var sut = await Template.Render("MultipleDuplicateIds.cshtml", new { TestText = "Hello World" });

            Assert.Equal(4, sut.GetAll.ByTestId("my-test-id").Count);
        }

        [Fact]
        public async Task ByTestId_ItReturnsNullWhenNoElementFound()
        {
            var sut = await Template.Render("MultipleDuplicateIds.cshtml", new { TestText = "Hello World" });
            Assert.Empty(sut.GetAll.ByTestId("not-a-real-id"));
        }

        [Fact]
        public async Task ByType_ItCanGet()
        {
            var sut = await Template.Render("MultipleDuplicateIds.cshtml", new { TestText = "Hello World" });
            Assert.Equal(4, sut.GetAll.ByType("div").Count);
        }

        [Fact]
        public async Task ByType_ItReturnsNullWhenNoElementFound()
        {
            var sut = await Template.Render("MultipleUniqueIds.cshtml", new { TestText = "Hello World" });
            Assert.Empty(sut.GetAll.ByType("not-real"));
        }

        [Fact]
        public async Task ByPartialName_ItCanGet()
        {
            var sut = await Template.Render("MultipleDuplicateIds.cshtml", new { TestText = "Hello World" });
            Assert.Equal(3, sut.GetAll.ByPartialName("common-partial").Count);
        }

        [Fact]
        public async Task ByPartialName_ItReturnsNullWhenNoElementFound()
        {
            var sut = await Template.Render("MultipleUniqueIds.cshtml", new { TestText = "Hello World" });
            Assert.Empty(sut.GetAll.ByPartialName("not-real"));
        }
    }
}