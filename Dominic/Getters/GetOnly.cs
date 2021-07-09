using Dominic.Exceptions;
using Dominic.Enums;
using System.Xml;
using Dominic.Models;

namespace Dominic.Getters
{
    public class GetOnly : ISelectorSingle
    {
        private Lookup _lookup;
        private XmlDocument _markup;

        internal GetOnly(Lookup lookup, XmlDocument markup)
        {
            _lookup = lookup;
            _markup = markup;
        }

        /// <inheritdoc />
        public Element ById(string id)
        {
            var elements = _lookup.QueryLookup(LookupType.Id, id);

            if(elements.Count > 1)
            {
                throw new TooManyElementsFoundException($"found too many elements matching id \"{id}\"");
            }

            return elements.Count > 0 ? elements[0] : null;
        }

        /// <inheritdoc />
        public Element ByType(string type)
        {
            var elements = _lookup.QueryLookup(LookupType.Type, type);

            if (elements.Count > 1)
            {
                throw new TooManyElementsFoundException($"found too many elements matching type \"{type}\"");
            }

            return elements.Count > 0 ? elements[0] : null;
        }

        /// <inheritdoc />
        public Element ByTestId(string testId)
        {
            var elements = _lookup.QueryLookup(LookupType.TestId, testId);

            if (elements.Count > 1)
            {
                throw new TooManyElementsFoundException($"found too many elements matching testId \"{testId}\"");
            }

            return elements.Count > 0 ? elements[0] : null;
        }

        /// <inheritdoc />
        public Element ByPartialName(string partialName)
        {
            var elements = _lookup.QueryLookup(LookupType.PartialName, partialName);
            
            PrintMarkup.WriteCouldNotFind(_markup, LookupType.PartialName, partialName);

            if (elements.Count > 1)
            {
                throw new TooManyElementsFoundException($"found too many elements matching partialName \"{partialName}\"");
            }

            return elements.Count > 0 ? elements[0] : null;
        }

        /// <inheritdoc />
        public Element ByAspFor(string aspFor)
        {
            var elements = _lookup.QueryLookup(LookupType.AspFor, aspFor);

            if (elements.Count > 1)
            {
                throw new TooManyElementsFoundException($"found too many elements matching asp-for \"{aspFor}\"");
            }

            return elements.Count > 0 ? elements[0] : null;
        }

        
        /// <inheritdoc />
        public Element ByAspAction(string aspAction)
        {
            var elements = _lookup.QueryLookup(LookupType.AspAction, aspAction);

            if (elements.Count > 1)
            {
                throw new TooManyElementsFoundException($"found too many elements matching asp-action \"{aspAction}\"");
            }

            return elements.Count > 0 ? elements[0] : null;
        }

        
        /// <inheritdoc />
        public Element ByAspController(string aspController)
        {
            var elements = _lookup.QueryLookup(LookupType.AspController, aspController);

            if (elements.Count > 1)
            {
                throw new TooManyElementsFoundException($"found too many elements matching asp-controller \"{aspController}\"");
            }

            return elements.Count > 0 ? elements[0] : null;
        }
    }
}