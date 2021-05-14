using System;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;
using Dominic.Getters;
using Dominic.Enums;
using RazorLight;
using RazorLight.Internal;
using Sgml;
using WhitespaceHandling = Sgml.WhitespaceHandling;

namespace Dominic
{
    public class Template
    {
        /// <summary>
        /// <see cref="Dominic.Getters.GetOnly">See GetOnly</see>
        /// </summary>
        public readonly GetOnly GetOnly;

        /// <summary>
        /// <see cref="Dominic.Getters.GetFirst">See GetFirst</see>
        /// </summary>
        public readonly GetFirst GetFirst;

        /// <summary>
        /// <see cref="Dominic.Getters.GetLast">See GetLast</see>
        /// </summary>
        public readonly GetLast GetLast;

        /// <summary>
        /// <see cref="Dominic.Getters.GetAll">See GetAll</see>
        /// </summary>
        public readonly GetAll GetAll;

        internal Template(XmlDocument document)
        {
            if (document == null)
            {
                throw new ArgumentException("the document cannot be null");
            }

            var lookup = new Lookup();
            lookup.BuildLookup(document);

            GetOnly = new GetOnly(lookup);
            GetFirst = new GetFirst(lookup);
            GetLast = new GetLast(lookup);
            GetAll = new GetAll(lookup);
        }

        ///  <summary>
        ///  
        ///  </summary>
        ///  <example>
        ///  <code>
        ///  Template myRenderedArticle = await Template.Render(
        ///      "MyArticle.cshtml",
        ///      new Article {Title = "My title", Author = "Aaron Buckley"}
        ///  );
        ///  </code>
        /// </example>
        ///  <param name="path">Path of the view you wish to test, relative to the path configured with <see cref="SetViewLocation">SetViewLocation(path)</see></param>
        ///  <param name="configuration">Configuration for the render engine to start up with</param>
        ///  <param name="model">View Model of the view you wish to test</param>
        ///  <typeparam name="T">Type of the View Model</typeparam>
        ///  <param name="viewData"></param>
        ///  <returns>A new instance of a rendered template, which can be queried.</returns>
        public static async Task<Template> Render<T>(string path, DominicConfiguration configuration, T model, ExpandoObject viewData = null)
        {
            var engine = StartEngine(configuration);

            var result = await engine.CompileRenderStringAsync(
                "templateKey",
                GetViewFromFile(path, configuration.ViewFolderLocation),
                model,
                viewData
            );

            // todo AB (05/03): this will fail if there is no root element, that should be tested for
            return new Template(FromHtml(GetTextReader(result)));
        }

        ///  <summary>
        ///  
        ///  </summary>
        ///  <example>
        ///  <code>
        ///  Template myRenderedArticle = await Template.Render("MySimpleTemplate.cshtml");
        ///  </code>
        /// </example>
        ///  <param name="path">Path of the view you wish to test, relative to the path configured with <see cref="SetViewLocation">SetViewLocation(path)</see></param>
        ///  <param name="configuration">Configuration for the render engine to start up with</param>
        ///  <param name="viewData"></param>
        ///  <returns>A new instance of a rendered template, which can be queried.</returns>
        public static async Task<Template> Render(string path, DominicConfiguration configuration, ExpandoObject viewData = null)
        {
            var engine = StartEngine(configuration);

            var result = await engine.CompileRenderStringAsync(
                "templateKey",
                GetViewFromFile(path, configuration.ViewFolderLocation),
                new DummyModel(),
                viewData
            );


            // todo AB (05/03): this will fail if there is no root element, that should be tested for
            return new Template(FromHtml(GetTextReader(result)));
        }

        private static string GetViewFromFile(string path, string viewFolderLocation)
        {
            var fullPath = $"{viewFolderLocation}/{path}";
            if (!File.Exists(fullPath))
            {
                throw new ArgumentException($"path of: \"{path}\" does not exist at: \"{viewFolderLocation}\"");
            }

            return File.ReadAllText(fullPath);
        }

        private static TextReader GetTextReader(string fromString)
        {
            return new StringReader(fromString);
        }

        private static XmlDocument FromHtml(TextReader reader)
        {
            // setup SgmlReader
            var sgmlReader = new SgmlReader
            {
                DocType = "HTML",
                WhitespaceHandling = WhitespaceHandling.All,
                CaseFolding = CaseFolding.ToLower,
                InputStream = reader
            };

            // create document
            var doc = new XmlDocument {PreserveWhitespace = true, XmlResolver = null};
            doc.Load(sgmlReader);
            return doc;
        }

        private static void SetupPreRenderCallbacks(RazorLightEngine engine, Func<Type, object> resolver)
        {
            engine.Options.PreRenderCallbacks.Add(template =>
            {
                var properties = template.GetType().GetRuntimeProperties()
                    .Where(p => p.IsDefined(typeof(RazorInjectAttribute))
                                &&
                                p.GetIndexParameters().Length ==
                                0 &&
                                !p.SetMethod.IsStatic).ToArray();

                foreach (var property in properties)
                {
                    var memberType = property.PropertyType;
                    var instance = resolver(memberType);

                    property.SetValue(template, instance);
                }
            });
        }

        private static RazorLightEngine StartEngine(DominicConfiguration configuration)
        {
            var project = new LayoutLocator($"{configuration.ViewFolderLocation}/Shared");
            var engine = new RazorLightEngineBuilder()
                .UseProject(project)
                .Build();
            SetupPreRenderCallbacks(engine, configuration.Resolver);

            return engine;
        }
    }
}