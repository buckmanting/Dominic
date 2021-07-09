using System.Xml;
using Dominic.Exceptions;
using Dominic.Models;

namespace Dominic.Getters
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISelectorSingle
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="TooManyElementsFoundException"></exception>
        Element ById(string id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="TooManyElementsFoundException"></exception>
        Element ByType(string type);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="testId"></param>
        /// <returns></returns>
        /// <exception cref="TooManyElementsFoundException"></exception>
        Element ByTestId(string testId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="partialName"></param>
        /// <returns></returns>
        /// <exception cref="TooManyElementsFoundException"></exception>
        Element ByPartialName(string partialName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aspFor"></param>
        /// <returns></returns>
        /// <exception cref="TooManyElementsFoundException"></exception>
        Element ByAspFor(string aspFor);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aspAction"></param>
        /// <returns></returns>
        /// <exception cref="TooManyElementsFoundException"></exception>
        Element ByAspAction(string aspAction);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aspController"></param>
        /// <returns></returns>
        /// <exception cref="TooManyElementsFoundException"></exception>
        Element ByAspController(string aspController);
    }
}