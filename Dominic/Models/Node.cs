using System.Collections.Generic;
using System.Linq;
using System.Xml;
using RazorLight.Extensions;

namespace Dominic.Models
{
    public class Element
    {
        public Element(XmlNode node)
        {
            Node = node;
        }

        /// <summary>
        /// An array of class on the element
        /// </summary>
        public IEnumerable<string> Classes => Node?.Attributes?["class"].Value.Split(' ').Where(c => !string.IsNullOrWhiteSpace(c));

        /// <summary>
        /// 
        /// </summary>
        public string InnerText => Node?.InnerText;

        /// <summary>
        /// 
        /// </summary>
        public string InnerHtml => Node?.InnerXml;
        
        /// <summary>
        /// 
        /// </summary>
        public Element FirstChild => new Element(Node?.FirstChild);
        
        /// <summary>
        /// 
        /// </summary>
        public Element LastChild => new Element(Node?.LastChild);

        /// <summary>
        /// 
        /// </summary>
        public Element[] Children
        {
            get
            {
                var result = new Element[Node.ChildNodes.Count];
                for (var i =0; i < Node.ChildNodes.Count; i++)
                {
                    result[i] = new Element(Node.ChildNodes[i]);
                }
                return result;
            }
        }

        /// <summary>
        /// Element as an XmlNode 
        /// </summary>
        public XmlNode Node { get; internal set; }
    }
}