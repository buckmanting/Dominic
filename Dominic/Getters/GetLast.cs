using System;
using System.Linq;
using System.Xml;
using Dominic.Enums;

namespace Dominic.Getters
{
    public class GetLast : ISelectorSingle
    {
        private Lookup _lookup;

        internal GetLast(Lookup lookup)
        {
            _lookup = lookup;
        }

        /// <inheritdoc />
        public XmlNode ById(string id)
        {
            return _lookup.QueryLookup(LookupType.Id, id).LastOrDefault();
        }

        /// <inheritdoc />
        public XmlNode ByType(string type)
        {
            return _lookup.QueryLookup(LookupType.Type, type).LastOrDefault();
        }

        /// <inheritdoc />
        public XmlNode ByTestId(string testId)
        {
            return _lookup.QueryLookup(LookupType.TestId, testId).LastOrDefault();
        }

        /// <inheritdoc />
        public XmlNode ByPartialName(string partialName)
        {
            return _lookup.QueryLookup(LookupType.PartialName, partialName).LastOrDefault();
        }

        /// <inheritdoc />
        public XmlNode ByAspFor(string aspFor)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public XmlNode ByAspAction(string aspAction)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public XmlNode ByAspController(string aspController)
        {
            throw new System.NotImplementedException();
        }
    }
}