using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Xunit;

namespace Dominic.Test.Helpers
{
    public class LookupTests
    {
        [Fact]
        public async Task ItBuildsALookup()
        {
            var currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            var path = $"{currentDirectory}/TestMarkup/LargeMainElement.html";
            var reader = File.ReadAllText(path);
            var sgmlReader = new Sgml.SgmlReader
            {
                DocType = "HTML",
                WhitespaceHandling = (Sgml.WhitespaceHandling)WhitespaceHandling.All,
                CaseFolding = Sgml.CaseFolding.ToLower,
                InputStream = new StringReader(reader)
            };

            // create document
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.XmlResolver = null;
            doc.Load(sgmlReader);

            var sut = new Dominic.Helpers.Lookup();
            sut.BuildLookup(doc);
        }

        [Fact]
        public async Task ItBuildsAComplexLookup()
        {
            var currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;
            var path = $"{currentDirectory}/TestMarkup/ComplexMarkup.html";
            var reader = File.ReadAllText(path);
            var sgmlReader = new Sgml.SgmlReader
            {
                DocType = "HTML",
                WhitespaceHandling = (Sgml.WhitespaceHandling)WhitespaceHandling.All,
                CaseFolding = Sgml.CaseFolding.ToLower,
                InputStream = new StringReader(reader)
            };

            // create document
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.XmlResolver = null;
            doc.Load(sgmlReader);

            var sut = new Dominic.Helpers.Lookup();
            sut.BuildLookup(doc);
        }
    }
}
