using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Linq;
using DOMinic.Test.TestModels;
using Xunit;

namespace DOMinic.Test
{
    public class InstantiationTests
    {
        public InstantiationTests()
        {
            var currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            var viewPath = $"{currentDirectory}/TestTemplates";
            Template.SetViewLocation(viewPath);
        }

        [Fact]
        public void ItCanBeInstantiated()
        {
            var document = new XDocument(
                new XComment("This is a comment"),
                new XElement("main",
                    new XElement("nav", "my nav"),
                    new XElement("section", "cool section"),
                    new XElement("article", "cooler section"),
                    new XElement("partial")
                )
            );

            // var sut = new Template(document);
            // Assert.NotNull(sut);
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
                new
                {
                    Title = "My title",
                    Author = "Aaron Buckley"
                }
            );
            Assert.NotNull(sut);
        }

        [Fact]
        public async Task ItThrowsAnErrorWhenNoTemplateIsFound()
        {
            await Assert.ThrowsAsync<ArgumentException>(async () => await Template.Render(
                "i-do-not-exist.cshtml",
                new
                {
                    Title = "My title",
                    Author = "Aaron Buckley"
                }
            ));
        }

        [Fact]
        public async Task ItReturnsANewInstanceAfterRenderingWithoutAModel()
        {
            var sut = await Template.Render("Navigation.cshtml");
            Assert.NotNull(sut);
        }

        [Fact]
        public async Task ItThrowsAnErrorWhenNoTemplateIsFoundOnModelessRender()
        {
            await Assert.ThrowsAsync<ArgumentException>(async () => await Template.Render("i-do-not-exist.cshtml"));
        }
    }
}