using System.Diagnostics;
using System.IO;
using System.Xml;
using Sgml;
using Xunit;
using WhitespaceHandling = System.Xml.WhitespaceHandling;

namespace Dominic.Test.Helpers
{
    public class LookupTests
    {
        [Fact]
        public void ItBuildsALookup()
        {
            var directoryInfo = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent;

            var currentDirectory = directoryInfo?.Parent;
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
            var doc = new XmlDocument {PreserveWhitespace = true, XmlResolver = null};
            doc.Load(sgmlReader);

            var sut = new Dominic.Enums.Lookup();
            sut.BuildLookup(doc);
        }

        [Fact]
        public void ItBuildsAComplexLookup()
        {
            var directoryInfo = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent;
            
            var currentDirectory = directoryInfo?.Parent;
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
            var doc = new XmlDocument {PreserveWhitespace = true, XmlResolver = null};
            doc.Load(sgmlReader);

            var sut = new Dominic.Enums.Lookup();
            sut.BuildLookup(doc);
        }

        [Fact]
        public void ItBuildsAComplexLookupFromChaoticMarkup()
        {
            var currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent;
            var path = $"{currentDirectory}/TestMarkup/LoadsOfNesting.html";
            var reader = File.ReadAllText(path);
            var sgmlReader = new SgmlReader
            {
                DocType = "HTML",
                WhitespaceHandling = (Sgml.WhitespaceHandling)WhitespaceHandling.All,
                CaseFolding = Sgml.CaseFolding.ToLower,
                InputStream = new StringReader(reader)
            };

            // create document
            var doc = new XmlDocument {PreserveWhitespace = true, XmlResolver = null!};
            doc.Load(sgmlReader);

            var sut = new Dominic.Enums.Lookup();
            var stopwatch = Stopwatch.StartNew();
            sut.BuildLookup(doc);
            stopwatch.Stop();
            
            Assert.True(stopwatch.ElapsedMilliseconds < 20, $"Ran in {stopwatch.ElapsedMilliseconds}ms, make it faster");
        }
    }
}
