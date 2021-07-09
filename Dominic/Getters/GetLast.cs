using System;
using System.Linq;
using System.Xml;
using Dominic.Enums;
using Dominic.Models;

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
        public Element ById(string id)
        {
            return _lookup.QueryLookup(LookupType.Id, id).LastOrDefault();
        }

        /// <inheritdoc />
        public Element ByType(string type)
        {
            return _lookup.QueryLookup(LookupType.Type, type).LastOrDefault();
        }

        /// <inheritdoc />
        public Element ByTestId(string testId)
        {
            return _lookup.QueryLookup(LookupType.TestId, testId).LastOrDefault();
        }

        /// <inheritdoc />
        public Element ByPartialName(string partialName)
        {
            return _lookup.QueryLookup(LookupType.PartialName, partialName).LastOrDefault();
        }

        /// <inheritdoc />
        public Element ByAspFor(string aspFor)
        {
            return _lookup.QueryLookup(LookupType.AspFor, aspFor).LastOrDefault();
        }

        /// <inheritdoc />
        public Element ByAspAction(string aspAction)
        {
            return _lookup.QueryLookup(LookupType.AspAction, aspAction).LastOrDefault();
        }

        /// <inheritdoc />
        public Element ByAspController(string aspController)
        {
            return _lookup.QueryLookup(LookupType.AspController, aspController).LastOrDefault();
        }
    }
}