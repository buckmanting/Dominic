using System;
using System.Dynamic;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using Dominic.Test.Models.TestModels;
using Dominic.Test.Models;
using Xunit;

namespace Dominic.Test
{
    public class TemplateTests
    {
        private DominicConfiguration _configuration;

        public TemplateTests()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var viewPath = $"{currentDirectory}/Views";

            _configuration = new DominicConfiguration { ViewFolderLocation = viewPath };
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
                "TestView/Article.cshtml",
                _configuration,
                new Article { Title = "My title", Author = "Aaron Buckley" }
            );
            Assert.NotNull(sut);
        }

        [Fact]
        public async Task ItRendersWithATemplate()
        {
            var sut = await Template.Render(
                "TestView/WithLayout.cshtml",
                _configuration,
                new Article { Title = "My title", Author = "Aaron Buckley" }
            );
            Assert.NotNull(sut);
        }

        [Fact]
        public async Task ItRendersWithADeclaredModel()
        {
            var sut = await Template.Render(
                "TestView/WithDeclaredModel.cshtml",
                _configuration,
                new ExternalTestType { IsCool = true, Name = "Aaron Buckley" }
            );
            Assert.NotNull(sut);
        }

        [Fact]
        public async Task ItRendersWithViewBag()
        {
            dynamic viewBag = new ExpandoObject();
            viewBag.Test = "do I work?";

            Template sut = await Template.Render(
                "TestView/WithViewBag.cshtml",
                _configuration,
                new ExternalTestType { IsCool = true, Name = "Aaron Buckley" },
                viewBag
            );
            Assert.NotNull(sut);

            var viewBagData = sut.GetOnly.ByType("h2");
            Assert.Equal(viewBag.Test, viewBagData.InnerText);
        }

        [Fact]
        public async Task ItThrowsAnErrorWhenNoTemplateIsFound()
        {
            await Assert.ThrowsAsync<ArgumentException>(async () => await Template.Render(
                "i-do-not-exist.cshtml",
                _configuration,
                new { Title = "My title", Author = "Aaron Buckley" }
            ));
        }

        [Fact]
        public async Task ItReturnsANewInstanceAfterRenderingWithoutAModel()
        {
            var sut = await Template.Render("TestView/Navigation.cshtml", _configuration);
            Assert.NotNull(sut);
        }

        [Fact]
        public async Task ItThrowsAnErrorWhenNoTemplateIsFoundOnModelessRender()
        {
            await Assert.ThrowsAsync<ArgumentException>(async () =>
                await Template.Render("i-do-not-exist.cshtml", _configuration));
        }

        [Fact]
        public async Task ItCanParseWithEmptyAttributes()
        {
            var sut = await Template.Render("TestView/Form.cshtml", _configuration, new { TestText = "my form title" });

            Assert.Equal("disabled", sut.GetOnly.ById("my-button").Attributes["disabled"].Value);
        }
    }
}