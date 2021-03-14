using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("DOMinic.Test")]
namespace DOMinic.Helpers
{
    internal class Lookup
    {
        // Looking up by, Looking for, CacheID(s) to find 
        internal Dictionary<(LookupType, string), List<XmlNode>> LookupTable;

        public Lookup()
        {
            LookupTable = new Dictionary<(LookupType, string), List<XmlNode>>();
        }

        public List<XmlNode> QueryLookup(LookupType lookupType, string lookupValue)
        {
            // throw if not built
            if (LookupTable.ContainsKey((lookupType, lookupValue)))
            {
                return LookupTable[(lookupType, lookupValue)];
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
                if (!string.IsNullOrWhiteSpace(node.Attributes?["id"]?.Value))
                {
                    AddLookupItem(LookupType.Id, node.Attributes["id"].Value, node);
                }

                // add test-id
                if (!string.IsNullOrWhiteSpace(node.Attributes?["data-testid"]?.Value))
                {
                    AddLookupItem(LookupType.TestId, node.Attributes["data-testid"].Value, node);
                }

                // add partialName
                if (node.Name.ToLower() == "partial")
                {
                    // should blow up if there is no name
                    AddLookupItem(LookupType.PartialName, node.Attributes["name"].Value, node);
                }

                // add type
                AddLookupItem(LookupType.Type, node.Name, node);

                // use recursion to add child nodes
                if (node.ChildNodes.Count > 0)
                {
                    WalkDOM(node.ChildNodes);
                }
            }
        }

        private void AddLookupItem(LookupType lookupType, string lookupValue, XmlNode node)
        {
            if (LookupTable.ContainsKey((lookupType, lookupValue)))
            {
                LookupTable[(lookupType, lookupValue)].Add(node);
            }
            else
            {
                LookupTable.Add((lookupType, lookupValue), new List<XmlNode> { node });
            }
        }
    }

    enum LookupType
    {
        Id,
        TestId,
        Type,
        PartialName
    }
}
