using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Dominic.Test")]
namespace Dominic.Enums
{
    internal class Lookup
    {
        // Looking up by, Looking for, CacheID(s) to find 
        private readonly Dictionary<(LookupType, string), List<XmlNode>> _lookupTable;

        public Lookup()
        {
            _lookupTable = new Dictionary<(LookupType, string), List<XmlNode>>();
        }

        public List<XmlNode> QueryLookup(LookupType lookupType, string lookupValue)
        {
            // throw if not built
            if (_lookupTable.ContainsKey((lookupType, lookupValue)))
            {
                return _lookupTable[(lookupType, lookupValue)];
            }
            else
            {
                return new List<XmlNode>();
            }
        }

        public void BuildLookup(XmlDocument document)
        {
            WalkDOM(document.ChildNodes);
            // mark as built
        }

        private void WalkDOM(XmlNodeList nodes)
        {
            for (var i = 0; i < nodes.Count; i++)
            {
                var node = nodes.Item(i);
                // add id
                if (!string.IsNullOrWhiteSpace(node?.Attributes?["id"]?.Value))
                {
                    AddLookupItem(LookupType.Id, node.Attributes["id"].Value, node);
                }

                // add test-id
                if (!string.IsNullOrWhiteSpace(node?.Attributes?["data-testid"]?.Value))
                {
                    AddLookupItem(LookupType.TestId, node.Attributes["data-testid"].Value, node);
                }

                // add partialName
                if (node?.Name.ToLower() == "partial")
                {
                    // should blow up if there is no name
                    AddLookupItem(LookupType.PartialName, node.Attributes?["name"]?.Value, node);
                }

                // add type
                AddLookupItem(LookupType.Type, node?.Name, node);

                // use recursion to add child nodes
                if (node?.ChildNodes.Count > 0)
                {
                    WalkDOM(node.ChildNodes);
                }
            }
        }

        private void AddLookupItem(LookupType lookupType, string lookupValue, XmlNode node)
        {
            if (_lookupTable.ContainsKey((lookupType, lookupValue)))
            {
                _lookupTable[(lookupType, lookupValue)].Add(node);
            }
            else
            {
                _lookupTable.Add((lookupType, lookupValue), new List<XmlNode> { node });
            }
        }
    }
}
