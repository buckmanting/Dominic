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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<XmlNode> ById(string id)
        {
            return _lookup.QueryLookup(LookupType.Id, id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<XmlNode> ByType(string type)
        {
            return _lookup.QueryLookup(LookupType.Type, type);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="testId"></param>
        /// <returns></returns>
        public List<XmlNode> ByTestId(string testId)
        {
            return _lookup.QueryLookup(LookupType.TestId, testId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="partialName"></param>
        /// <returns></returns>
        public List<XmlNode> ByPartialName(string partialName)
        {
            return _lookup.QueryLookup(LookupType.PartialName, partialName);
        }
    }
}