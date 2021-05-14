using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace Dominic.Test
{
    public class ExternalTemplateTests
    {
        private DominicConfiguration _configuration;
        public ExternalTemplateTests()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var viewPath = $"{currentDirectory}/Views";
            
            _configuration = new DominicConfiguration {ViewFolderLocation = viewPath};
        }

        [Fact]
        public async Task ItCanRenderWithDeclaredTemplate()
        {
            var sut = await Template.Render("TestView/WithLayout.cshtml", _configuration);
            Assert.NotNull(sut);
        }
    }
}