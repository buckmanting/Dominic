using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace Dominic.Test
{
    public class ExternalTemplateTests
    {
        public ExternalTemplateTests()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var viewPath = $"{currentDirectory}/Views";
            Template.SetViewLocation(viewPath);
        }

        [Fact]
        public async Task ItCanRenderWithDeclaredTemplate()
        {
            var sut = await Template.Render("TestView/WithLayout.cshtml");
            Assert.NotNull(sut);
        }
    }
}