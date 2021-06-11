using System.Xml;
using Dominic.Exceptions;

namespace Dominic.Getters
{
    public interface ISelectorSingle
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="TooManyElementsFoundException"></exception>
        XmlNode ById(string id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="TooManyElementsFoundException"></exception>
        XmlNode ByType(string type);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="testId"></param>
        /// <returns></returns>
        /// <exception cref="TooManyElementsFoundException"></exception>
        XmlNode ByTestId(string testId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="partialName"></param>
        /// <returns></returns>
        /// <exception cref="TooManyElementsFoundException"></exception>
        XmlNode ByPartialName(string partialName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aspFor"></param>
        /// <returns></returns>
        /// <exception cref="TooManyElementsFoundException"></exception>
        XmlNode ByAspFor(string aspFor);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aspAction"></param>
        /// <returns></returns>
        /// <exception cref="TooManyElementsFoundException"></exception>
        XmlNode ByAspAction(string aspAction);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aspController"></param>
        /// <returns></returns>
        /// <exception cref="TooManyElementsFoundException"></exception>
        XmlNode ByAspController(string aspController);
    }
}