using System;
using System.Linq;
using System.Xml;
using Dominic.Enums;
using Dominic.Models;

namespace Dominic.Getters
{
    public class GetFirst : ISelectorSingle
    {
        private Lookup _lookup;
        internal GetFirst(Lookup lookup)
        {
            _lookup = lookup;
        }

        
        /// <inheritdoc />
        public Element ById(string id)
        {
            return _lookup.QueryLookup(LookupType.Id, id).FirstOrDefault();
        }

        
        /// <inheritdoc />
        public Element ByType(string type)
        {
            return _lookup.QueryLookup(LookupType.Type, type).FirstOrDefault();
        }

        
        /// <inheritdoc />
        public Element ByTestId(string testId)
        {
            return _lookup.QueryLookup(LookupType.TestId, testId).FirstOrDefault();
        }

        
        /// <inheritdoc />
        public Element ByPartialName(string partialName)
        {
            return _lookup.QueryLookup(LookupType.PartialName, partialName).FirstOrDefault();
        }

        
        /// <inheritdoc />
        public Element ByAspFor(string aspFor)
        {
            return _lookup.QueryLookup(LookupType.AspFor, aspFor).FirstOrDefault();
        }

        
        /// <inheritdoc />
        public Element ByAspAction(string aspAction)
        {
            return _lookup.QueryLookup(LookupType.AspAction, aspAction).FirstOrDefault();
        }

        
        /// <inheritdoc />
        public Element ByAspController(string aspController)
        {
            return _lookup.QueryLookup(LookupType.AspController, aspController).FirstOrDefault();
        }
    }
}