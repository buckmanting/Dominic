using System.Xml;
using System.Xml.Linq;
using DOMinic.Interfaces;

namespace DOMinic.Getters
{
    public class GetLast : IGetter
    {
        private XmlDocument _document;
        internal GetLast(XmlDocument document)
        {
            _document = document;
        }
        
        public XNode ById(string id)
        {
            throw new System.NotImplementedException();
        }

        public XNode ByType(string type)
        {
            throw new System.NotImplementedException();
        }

        public XNode ByTestId(string testId)
        {
            throw new System.NotImplementedException();
        }

        public XNode ByPartialName(string partialName)
        {
            throw new System.NotImplementedException();
        }
    }
}