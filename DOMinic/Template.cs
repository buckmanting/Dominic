using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using RazorLight;

namespace DOMinic
{
    public class Template
    {
        private XDocument _document;
        private static string _viewFolderLocation;

        public Template(XDocument document)
        {
            if (document == null)
            {
                throw new ArgumentException("the document cannot be null");
            }

            _document = document;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id of the element to be returned</param>
        /// <exception cref="InvalidOperationException">thrown where more than one matching element is found</exception>
        /// <returns>element matching with an id matching the provided parameter</returns>
        public XElement GetOnlyById(string id)
        {
            return _document.Root
                .Elements()
                .SingleOrDefault(el => (string) el.Attribute("id") == id);
        }

        // todo AB (05/03/20): test this dumb code
        public XElement GetOnlyByTestId(string testId)
        {
            // if nothing is found do we throw to break early and control the error, or return null and be unclear in test report?
            return _document.Root
                .Elements()
                .SingleOrDefault(el => (string) el.Attribute("data-testId") == testId);
        }

        // todo AB (05/03/20): test this dumb code
        public IEnumerable<XElement> GetAllByTestId(string testId)
        {
            return _document?.Root?
                .Elements()
                .Where(el => (string) el.Attribute("data-testId") == testId);
        }

        // todo AB (05/03/20): test this dumb code
        public XElement GetOnlyByType(string type)
        {
            // if nothing is found do we throw to break early and control the error, or return null and be unclear in test report?
            return _document.Root.Elements()
                .SingleOrDefault(el => el.Name == type);
        }

        // todo AB (05/03/20): test this dumb code
        public IEnumerable<XElement> GetAllByType(string type)
        {
            return _document?.Root?
                .Elements()
                .Where(el => el.Name == type);
        }

        // todo AB (05/03/20): test this dumb code
        public XElement GetOnlyByPartialName(string partialName)
        {
            // if nothing is found do we throw to break early and control the error, or return null and be unclear in test report?
            return _document.Root.Elements()
                .SingleOrDefault(el => el.Name == "partial" && (string) el.Attribute("name") == partialName);
        }

        // todo AB (05/03/20): test this dumb code
        public IEnumerable<XElement> GetAllByPartialName(string partialName)
        {
            return _document?.Root?
                .Elements()
                .Where(el => el.Name == "partial" && (string) el.Attribute("name") == partialName);
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

            return new Template(XDocument.Parse(result, LoadOptions.PreserveWhitespace));
        }

        public static async Task<Template> Render(string path)
        {
            var engine = new RazorLightEngineBuilder()
                .UseEmbeddedResourcesProject(typeof(DummyModel))
                .SetOperatingAssembly(typeof(DummyModel).Assembly)
                // .UseMemoryCachingProvider()
                .Build();

            var result = await engine.CompileRenderStringAsync(
                "templateKey",
                GetViewFromFile(path),
                new DummyModel()
            );

            return new Template(XDocument.Parse(result, LoadOptions.PreserveWhitespace));
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
    }
}