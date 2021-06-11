using Dominic.Exceptions;
using Dominic.Enums;
using System.Xml;

namespace Dominic.Getters
{
    public class GetOnly : ISelectorSingle
    {
        private Lookup _lookup;
        internal GetOnly(Lookup lookup)
        {
            _lookup = lookup;
        }

        /// <inheritdoc />
        public XmlNode ById(string id)
        {
            var elements = _lookup.QueryLookup(LookupType.Id, id);

            if(elements.Count > 1)
            {
                throw new TooManyElementsFoundException($"found too many elements matching id \"{id}\"");
            }

            return elements.Count > 0 ? elements[0] : null;
        }

        
        /// <inheritdoc />
        public XmlNode ByType(string type)
        {
            var elements = _lookup.QueryLookup(LookupType.Type, type);

            if (elements.Count > 1)
            {
                throw new TooManyElementsFoundException($"found too many elements matching type \"{type}\"");
            }

            return elements.Count > 0 ? elements[0] : null;
        }

        
        /// <inheritdoc />
        public XmlNode ByTestId(string testId)
        {
            var elements = _lookup.QueryLookup(LookupType.TestId, testId);

            if (elements.Count > 1)
            {
                throw new TooManyElementsFoundException($"found too many elements matching testId \"{testId}\"");
            }

            return elements.Count > 0 ? elements[0] : null;
        }

        
        /// <inheritdoc />
        public XmlNode ByPartialName(string partialName)
        {
            var elements = _lookup.QueryLookup(LookupType.PartialName, partialName);

            if (elements.Count > 1)
            {
                throw new TooManyElementsFoundException($"found too many elements matching partialName \"{partialName}\"");
            }

            return elements.Count > 0 ? elements[0] : null;
        }

        
        /// <inheritdoc />
        public XmlNode ByAspFor(string aspFor)
        {
            var elements = _lookup.QueryLookup(LookupType.AspFor, aspFor);

            if (elements.Count > 1)
            {
                throw new TooManyElementsFoundException($"found too many elements matching asp-for \"{aspFor}\"");
            }

            return elements.Count > 0 ? elements[0] : null;
        }

        
        /// <inheritdoc />
        public XmlNode ByAspAction(string aspAction)
        {
            var elements = _lookup.QueryLookup(LookupType.AspAction, aspAction);

            if (elements.Count > 1)
            {
                throw new TooManyElementsFoundException($"found too many elements matching asp-action \"{aspAction}\"");
            }

            return elements.Count > 0 ? elements[0] : null;
        }

        
        /// <inheritdoc />
        public XmlNode ByAspController(string aspController)
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