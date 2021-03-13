using System.Xml;
using System.Xml.Linq;

namespace DOMinic.Interfaces
{
    public interface IGetter
    {
        XNode ById(string id);
        XNode ByType(string type);
        XNode ByTestId(string testId);
        XNode ByPartialName(string partialName);
    }
}