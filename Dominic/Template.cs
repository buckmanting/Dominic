using System;
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
        private static string _viewFolderLocation;
        private static Func<Type, object> _resolver;

        /// <summary>
        /// 
        /// </summary>
        public readonly GetOnly GetOnly;
        
        /// <summary>
        /// 
        /// </summary>
        public readonly GetFirst GetFirst;
        
        /// <summary>
        /// 
        /// </summary>
        public readonly GetLast GetLast;
        
        /// <summary>
        /// 
        /// </summary>
        public readonly GetAll GetAll;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="document"></param>
        /// <exception cref="ArgumentException"></exception>
        public Template(XmlDocument document)
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path">Path of the view you wish to test, relative to the path configured with <see cref="SetViewLocation">SetViewLocation(path)</see></param>
        /// <param name="model">View Model of the view you wish to test</param>
        /// <typeparam name="T">Type of the View Model</typeparam>
        /// <returns></returns>
        public static async Task<Template> Render<T>(string path, T model)
        {
            //todo add null/empty check on _viewFolderLocation
            var engine = new RazorLightEngineBuilder()
                .UseFileSystemProject(_viewFolderLocation)
                .Build();

            SetupPreRenderCallbacks(ref engine);

            var result = await engine.CompileRenderStringAsync(
                "templateKey",
                GetViewFromFile(path),
                model
            );

            // todo AB (05/03): this will fail if there is no root element, that should be tested for
            return new Template(FromHtml(GetTextReader(result)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static async Task<Template> Render(string path)
        {
            //todo add null/empty check on _viewFolderLocation
            var engine = new RazorLightEngineBuilder()
                .UseFileSystemProject(_viewFolderLocation)
                .Build();

            SetupPreRenderCallbacks(ref engine);

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        public static void SetViewLocation(string path)
        {
            _viewFolderLocation = path;
        }

        /// <summary>
        /// TODO add documentation
        /// </summary>
        /// <param name="func"></param>
        public static void SetResolver(Func<Type, object> func)
        {
            _resolver = func;
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
            var doc = new XmlDocument { PreserveWhitespace = true, XmlResolver = null };
            doc.Load(sgmlReader);
            return doc;
        }

        private static void SetupPreRenderCallbacks(ref RazorLightEngine engine)
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
                    var instance = _resolver(memberType);

                    property.SetValue(template, instance);
                }
            });
        }
    }
}