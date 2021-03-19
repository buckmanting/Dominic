using System.Linq;
using System.Xml;
using Dominic.Enums;

namespace Dominic.Getters
{
    public class GetLast
    {
        private Lookup _lookup;

        internal GetLast(Lookup lookup)
        {
            _lookup = lookup;
        }

        public XmlNode ById(string id)
        {
            return _lookup.QueryLookup(LookupType.Id, id).LastOrDefault();
        }

        public XmlNode ByType(string type)
        {
            return _lookup.QueryLookup(LookupType.Type, type).LastOrDefault();
        }

        public XmlNode ByTestId(string testId)
        {
            return _lookup.QueryLookup(LookupType.TestId, testId).LastOrDefault();
        }

        public XmlNode ByPartialName(string partialName)
        {
            return _lookup.QueryLookup(LookupType.PartialName, partialName).LastOrDefault();
        }
    }
}