using Dominic.Exceptions;
using Dominic.Helpers;
using System.Xml;

namespace Dominic.Getters
{
    public class GetOnly
    {
        private Lookup _lookup;
        internal GetOnly(Lookup lookup)
        {
            _lookup = lookup;
        }

        public XmlNode ById(string id)
        {
            var elements = _lookup.QueryLookup(LookupType.Id, id);

            if(elements.Count > 1)
            {
                throw new TooManyElementsFoundException($"found too many elements matching id \"{id}\"");
            }

            return elements.Count > 0 ? elements[0] : null;
        }

        public XmlNode ByType(string type)
        {
            var elements = _lookup.QueryLookup(LookupType.Type, type);

            if (elements.Count > 1)
            {
                throw new TooManyElementsFoundException($"found too many elements matching type \"{type}\"");
            }

            return elements.Count > 0 ? elements[0] : null;
        }

        public XmlNode ByTestId(string testId)
        {
            var elements = _lookup.QueryLookup(LookupType.TestId, testId);

            if (elements.Count > 1)
            {
                throw new TooManyElementsFoundException($"found too many elements matching testId \"{testId}\"");
            }

            return elements.Count > 0 ? elements[0] : null;
        }

        public XmlNode ByPartialName(string partialName)
        {
            var elements = _lookup.QueryLookup(LookupType.PartialName, partialName);

            if (elements.Count > 1)
            {
                throw new TooManyElementsFoundException($"found too many elements matching partialName \"{partialName}\"");
            }

            return elements.Count > 0 ? elements[0] : null;
        }
    }
}