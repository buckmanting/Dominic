using System;
using System.IO;
using System.Xml;

namespace Dominic.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public class PrintMarkup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="markup"></param>
        /// <param name="type"></param>
        /// <param name="selector"></param>
        public static void WriteCouldNotFind(XmlDocument markup, LookupType type, string selector)
        {
            Console.WriteLine($"Could not find \"{type.ToString()}\" matching \"{selector}\" in the following markup");
            var result = GetXml(markup);
            Console.WriteLine(result);
        }

        private static string GetXml(XmlDocument markup)
        {
            string result;
            using (StringWriter writer = new StringWriter())
            {
                markup.Save(writer);
                result = writer.ToString();
            }

            return result;
        }
    }
}