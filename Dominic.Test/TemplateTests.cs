using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Dominic.Test.TestModels;
using Xunit;

namespace Dominic.Test
{
    using Models;

    public class TemplateTests
    {
        public TemplateTests()
        {
            var currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            var viewPath = $"{currentDirectory}/TestTemplates";
            Template.SetViewLocation(viewPath);
        }

        [Fact]
        public void ItCanBeInstantiated()
        {
            var document = new XmlDocument();

            var sut = new Template(document);
            Assert.NotNull(sut);
        }

        [Fact]
        public void ItFailsToInstantiateWhenDocumentIsInvalid()
        {
            Assert.Throws<ArgumentException>(() => new Template(null));
        }

        [Fact]
        public async Task ItReturnsANewInstanceAfterRendering()
        {
            var sut = await Template.Render(
                "Article.cshtml",
                new {Title = "My title", Author = "Aaron Buckley"},
                "Dominic.Tests.TestTemplates"
            );
            Assert.NotNull(sut);
        }

        [Fact(Skip= "one issue at a time")]
        public async Task ItRendersWithATemplate()
        {
            var sut = await Template.Render(
                "WithLayout.cshtml",
                new {Title = "My title", Author = "Aaron Buckley"},
                "Dominic.Test.TestTemplates"
            );
            Assert.NotNull(sut);
        }

        [Fact]
        public async Task ItRendersWithADeclaredModel()
        {
            var sut = await Template.Render(
                "WithDeclaredModel.cshtml",
                new ExternalTestType {IsCool = true, Name = "Aaron Buckley"},
                "Dominic.Test.TestTemplates"
            );
            Assert.NotNull(sut);
        }

        [Fact]
        public async Task ItThrowsAnErrorWhenNoTemplateIsFound()
        {
            await Assert.ThrowsAsync<ArgumentException>(async () => await Template.Render(
                "i-do-not-exist.cshtml",
                new {Title = "My title", Author = "Aaron Buckley"},
                "Dominic.Tests.TestTemplates"
            ));
        }

        [Fact]
        public async Task ItReturnsANewInstanceAfterRenderingWithoutAModel()
        {
            var sut = await Template.Render("Navigation.cshtml", "Dominic.Tests.TestTemplates");
            Assert.NotNull(sut);
        }

        [Fact]
        public async Task ItThrowsAnErrorWhenNoTemplateIsFoundOnModelessRender()
        {
            await Assert.ThrowsAsync<ArgumentException>(async () =>
                await Template.Render("i-do-not-exist.cshtml", "Dominic.Tests.TestTemplates"));
        }

        [Fact]
        public async Task ItCanParseWithEmptyAttributes()
        {
            var sut = await Template.Render("Form.cshtml", new {TestText = "my form title"},
                "Dominic.Tests.TestTemplates");

            Assert.Equal("disabled", sut.GetOnly.ById("my-button").Attributes["disabled"].Value);
        }
    }
}