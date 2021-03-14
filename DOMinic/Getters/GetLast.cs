using System.Xml;
using System.Xml.Linq;

namespace DOMinic.Getters
{
    public class GetLast
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