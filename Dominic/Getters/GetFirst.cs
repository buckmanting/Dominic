using System.Linq;
using System.Xml;
using Dominic.Enums;

namespace Dominic.Getters
{
    public class GetFirst
    {
        private Lookup _lookup;
        internal GetFirst(Lookup lookup)
        {
            _lookup = lookup;
        }

        public XmlNode ById(string id)
        {
            return _lookup.QueryLookup(LookupType.Id, id).FirstOrDefault();
        }

        public XmlNode ByType(string type)
        {
            return _lookup.QueryLookup(LookupType.Type, type).FirstOrDefault();
        }

        public XmlNode ByTestId(string testId)
        {
            return _lookup.QueryLookup(LookupType.TestId, testId).FirstOrDefault();
        }

        public XmlNode ByPartialName(string partialName)
        {
            return _lookup.QueryLookup(LookupType.PartialName, partialName).FirstOrDefault();
        }
    }
}