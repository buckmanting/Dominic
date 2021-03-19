using Dominic.Enums;
using System.Collections.Generic;
using System.Xml;

namespace Dominic.Getters
{
    public class GetAll
    {
        private Lookup _lookup;
        internal GetAll(Lookup lookup)
        {
            _lookup = lookup;
        }

        public List<XmlNode> ById(string id)
        {
            return _lookup.QueryLookup(LookupType.Id, id);
        }

        public List<XmlNode> ByType(string type)
        {
            return _lookup.QueryLookup(LookupType.Type, type);
        }

        public List<XmlNode> ByTestId(string testId)
        {
            return _lookup.QueryLookup(LookupType.TestId, testId);
        }

        public List<XmlNode> ByPartialName(string partialName)
        {
            return _lookup.QueryLookup(LookupType.PartialName, partialName);
        }
    }
}