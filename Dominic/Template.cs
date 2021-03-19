using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using Dominic.Getters;
using Dominic.Helpers;
using RazorLight;
using Sgml;
using WhitespaceHandling = Sgml.WhitespaceHandling;

namespace Dominic
{
    public class Template
    {
        private readonly XmlDocument _htmlDocument;
        private static string _viewFolderLocation;
        private Lookup _lookup;

        public GetOnly GetOnly;
        public GetFirst GetFirst;
        public GetLast GetLast;
        public GetAll GetAll;

        public Template(XmlDocument document)
        {
            if (document == null)
            {
                throw new ArgumentException("the document cannot be null");
            }

            _htmlDocument = document;

            _lookup = new Lookup();
            _lookup.BuildLookup(_htmlDocument);

            GetOnly = new GetOnly(_lookup);
            GetFirst = new GetFirst(_htmlDocument);
            GetLast = new GetLast(_htmlDocument);
            GetAll = new GetAll(_lookup);
        }

        public static async Task<Template> Render<T>(string path, T model)
        {
            var engine = new RazorLightEngineBuilder()
                .UseEmbeddedResourcesProject(typeof(T))
                .SetOperatingAssembly(typeof(T).Assembly)
                .UseMemoryCachingProvider()
                .Build();

            var result = await engine.CompileRenderStringAsync(
                "templateKey",
                GetViewFromFile(path),
                model
            );

            // todo AB (05/03): this will fail if there is no root element, that should be tested for
            return new Template(FromHtml(GetTextReader(result)));
        }

        public static async Task<Template> Render(string path)
        {
            var engine = new RazorLightEngineBuilder()
                .UseEmbeddedResourcesProject(typeof(DummyModel))
                .SetOperatingAssembly(typeof(DummyModel).Assembly)
                .Build();

            var result = await engine.CompileRenderStringAsync(
                "templateKey",
                GetViewFromFile(path),
                new DummyModel()
            );

            // todo AB (05/03): this will fail if there is no root element, that should be tested for
            return new Template(FromHtml(GetTextReader(result)));
        }

        private static string GetViewFromFile(string path)
        {
            var fullPath = $"{_viewFolderLocation}/{path}";
            if (!File.Exists(fullPath))
            {
                throw new ArgumentException($"path of: \"{path}\" does not exist at: \"{_viewFolderLocation}\"");
            }

            return File.ReadAllText(fullPath);
        }

        public static void SetViewLocation(string path)
        {
            _viewFolderLocation = path;
        }

        private static TextReader GetTextReader(string fromString)
        {
            return new StringReader(fromString);
        }

        private static XmlDocument FromHtml(TextReader reader)
        {
            // setup SgmlReader
            var sgmlReader = new SgmlReader();
            sgmlReader.DocType = "HTML";
            sgmlReader.WhitespaceHandling = WhitespaceHandling.All;
            sgmlReader.CaseFolding = CaseFolding.ToLower;
            sgmlReader.InputStream = reader;

            // create document
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.XmlResolver = null;
            doc.Load(sgmlReader);
            return doc;
        }
    }
}