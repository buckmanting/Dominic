using System.Collections.Generic;
using System.Xml;
using Dominic.Models;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Dominic.Test")]

namespace Dominic.Enums
{
    internal class Lookup
    {
        // Looking up by, Looking for, CacheID(s) to find 
        private readonly Dictionary<(LookupType, string), List<Element>> _lookupTable;

        internal Lookup()
        {
            _lookupTable = new Dictionary<(LookupType, string), List<Element>>();
        }

        internal List<Element> QueryLookup(LookupType lookupType, string lookupValue)
        {
            // throw if not built
            if (_lookupTable.ContainsKey((lookupType, lookupValue)))
            {
                return _lookupTable[(lookupType, lookupValue)];
            }

            return new List<Element>();
        }

        internal void BuildLookup(XmlDocument document)
        {
            WalkDOM(document.ChildNodes);
            // mark as built
        }

        // Given that DOM is an acronym, we will disable the `InconsistentNaming` warning
        // ReSharper disable once InconsistentNaming
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

                // add asp-for
                if (!string.IsNullOrWhiteSpace(node?.Attributes?["asp-for"]?.Value))
                {
                    AddLookupItem(LookupType.AspFor, node.Attributes?["asp-for"]?.Value, node);
                }

                // add asp-action
                if (!string.IsNullOrWhiteSpace(node?.Attributes?["asp-action"]?.Value))
                {
                    AddLookupItem(LookupType.AspAction, node.Attributes?["asp-action"]?.Value, node);
                }

                // add asp-controller
                if (!string.IsNullOrWhiteSpace(node?.Attributes?["asp-controller"]?.Value))
                {
                    AddLookupItem(LookupType.AspController, node.Attributes?["asp-controller"]?.Value, node);
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
            var element = new Element(node);

            if (_lookupTable.ContainsKey((lookupType, lookupValue)))
            {
                _lookupTable[(lookupType, lookupValue)].Add(element);
            }
            else
            {
                _lookupTable.Add((lookupType, lookupValue), new List<Element> { element });
            }
        }
    }
}