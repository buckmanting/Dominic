using System.Diagnostics;
using System.IO;
using System.Xml;
using Dominic.Enums;
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
                WhitespaceHandling = (Sgml.WhitespaceHandling) WhitespaceHandling.All,
                CaseFolding = Sgml.CaseFolding.ToLower,
                InputStream = new StringReader(reader)
            };

            // create document
            var doc = new XmlDocument { PreserveWhitespace = true, XmlResolver = null };
            doc.Load(sgmlReader);

            var sut = new Enums.Lookup();
            sut.BuildLookup(doc);
        }

        [Theory]
        [InlineData(LookupType.Id, "button-id", 1)]
        [InlineData(LookupType.TestId, "h1-test-id", 1)]
        [InlineData(LookupType.Type, "label", 3)]
        [InlineData(LookupType.PartialName, "_ErrorPartial", 3)]
        [InlineData(LookupType.AspFor, "LastName", 1)]
        [InlineData(LookupType.AspAction, "ExampleAction", 1)]
        [InlineData(LookupType.AspController, "Home", 2)]
        public void ItAddsLookupTypes(LookupType lookupType, string queryParam, int expectedCount)
        {
            // Arrange
            var directoryInfo = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent;

            var currentDirectory = directoryInfo?.Parent;
            var path = $"{currentDirectory}/TestMarkup/ExampleForm.html";
            var reader = File.ReadAllText(path);
            var sgmlReader = new SgmlReader
            {
                DocType = "HTML",
                WhitespaceHandling = (Sgml.WhitespaceHandling) WhitespaceHandling.All,
                CaseFolding = CaseFolding.ToLower,
                InputStream = new StringReader(reader)
            };

            // create document
            var doc = new XmlDocument { PreserveWhitespace = true, XmlResolver = null };
            doc.Load(sgmlReader);

            var sut = new Lookup();
            sut.BuildLookup(doc);

            // Act
            var queryResult = sut.QueryLookup(lookupType, queryParam);
            
            // Assert
            Assert.Equal(expectedCount, queryResult.Count);
        }

        [Fact]
        public void ItBuildsAComplexLookup()
        {
            var directoryInfo = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent;

            var currentDirectory = directoryInfo?.Parent;
            var path = $"{currentDirectory}/TestMarkup/ComplexMarkup.html";
            var reader = File.ReadAllText(path);
            var sgmlReader = new SgmlReader
            {
                DocType = "HTML",
                WhitespaceHandling = (Sgml.WhitespaceHandling) WhitespaceHandling.All,
                CaseFolding = CaseFolding.ToLower,
                InputStream = new StringReader(reader)
            };

            // create document
            var doc = new XmlDocument { PreserveWhitespace = true, XmlResolver = null };
            doc.Load(sgmlReader);

            var sut = new Enums.Lookup();
            sut.BuildLookup(doc);
        }

        // todo remove this and make a proper suit of perf tests
        [Fact]
        public void ItBuildsAComplexLookupFromChaoticMarkup()
        {
            var currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent;
            var path = $"{currentDirectory}/TestMarkup/LoadsOfNesting.html";
            var reader = File.ReadAllText(path);
            var sgmlReader = new SgmlReader
            {
                DocType = "HTML",
                WhitespaceHandling = (Sgml.WhitespaceHandling) WhitespaceHandling.All,
                CaseFolding = Sgml.CaseFolding.ToLower,
                InputStream = new StringReader(reader)
            };

            // create document
            var doc = new XmlDocument { PreserveWhitespace = true, XmlResolver = null! };
            doc.Load(sgmlReader);

            var sut = new Dominic.Enums.Lookup();
            var stopwatch = Stopwatch.StartNew();
            sut.BuildLookup(doc);
            stopwatch.Stop();

            Assert.True(stopwatch.ElapsedMilliseconds < 100,
                $"Ran in {stopwatch.ElapsedMilliseconds}ms, make it faster");
        }
    }
}