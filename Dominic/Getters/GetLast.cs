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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public XmlNode ById(string id)
        {
            return _lookup.QueryLookup(LookupType.Id, id).LastOrDefault();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public XmlNode ByType(string type)
        {
            return _lookup.QueryLookup(LookupType.Type, type).LastOrDefault();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="testId"></param>
        /// <returns></returns>
        public XmlNode ByTestId(string testId)
        {
            return _lookup.QueryLookup(LookupType.TestId, testId).LastOrDefault();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="partialName"></param>
        /// <returns></returns>
        public XmlNode ByPartialName(string partialName)
        {
            return _lookup.QueryLookup(LookupType.PartialName, partialName).LastOrDefault();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aspFor"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public XmlNode ByAspFor(string aspFor)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aspAction"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public XmlNode ByAspAction(string aspAction)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aspController"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public XmlNode ByAspController(string aspController)
        {
            throw new System.NotImplementedException();
        }
    }
}