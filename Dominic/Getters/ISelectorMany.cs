using System.Collections.Generic;
using System.Xml;

namespace Dominic.Getters
{
    public interface ISelectorMany
    {
        /// <summary>
        /// Used to find all matching node in the rendered template where the node's <c>id</c> matches the provided parameter value.
        /// </summary>
        /// <example>
        /// Sample template
        /// <code>
        /// <div>
        /// <p id="example-id">
        /// My cool paragraph 😎
        /// </p>
        /// <p>
        /// Don't try and find me!
        /// </p>
        /// <div id="example-id">
        /// My other cool paragraph 😎
        /// </div>
        /// </div>
        /// </code>
        /// Your code
        /// <code>
        /// var nodes = myRenderedArticle.GetAll.ById("example-id");
        /// </code>
        /// Returns
        /// <code>
        /// <p id="example-id">My cool paragraph 😎</p>
        /// <div id="example-id">My other cool paragraph 😎</div>
        /// </code>
        ///</example>
        /// <param name="id"><c>Id</c> of the desired nodes</param>
        /// <returns>A list of nodes in the template that have the supplied <c>id</c></returns>
        List<XmlNode> ById(string id);

        /// <summary>
        /// Used to find all matching node in the rendered template where the node's <c>type</c> matches the provided parameter value.
        /// </summary>
        /// <example>
        /// Sample template
        /// <code>
        /// <div>
        /// <p>
        /// My cool paragraph 😎
        /// </p>
        /// <p>
        /// Try and find me!
        /// </p>
        /// <div>
        /// My other cool paragraph 😎
        /// </div>
        /// </div>
        /// </code>
        /// Your code
        /// <code>
        /// var nodes = myRenderedArticle.GetAll.ByType("p");
        /// </code>
        /// Returns
        /// <code>
        /// <p>My cool paragraph 😎</p>
        /// <p>Try and find me!</p>
        /// </code>
        ///</example>
        /// <param name="type"><c>type</c> of the desired nodes, for example <c>div</c>, <c>main</c>, <c>p</c></param>
        /// <returns>A list of nodes in the template that have the supplied <c>id</c></returns>
        List<XmlNode> ByType(string type);

        /// <summary>
        /// Used to find all matching node in the rendered template where the node's <c>data-testId</c> attribute matches the provided parameter value.
        /// </summary>
        /// <example>
        /// Sample template
        /// <code>
        /// <div>
        /// <p data-testId="example-testId">
        /// My cool paragraph 😎
        /// </p>
        /// <p data-testId="some-other-testId">
        /// Try and find me!
        /// </p>
        /// <div data-testId="example-testId">
        /// My other cool paragraph 😎
        /// </div>
        /// </div>
        /// </code>
        /// Your code
        /// <code>
        /// var nodes = myRenderedArticle.GetAll.ByTestId("example-testId");
        /// </code>
        /// Returns
        /// <code>
        /// <p data-testId="example-testId">My cool paragraph 😎</p>
        /// <div data-testId="example-testId">My other cool paragraph 😎</div>
        /// </code>
        ///</example>
        /// <param name="testId"><c>data-testId</c> attribute value of the desired nodes</param>
        /// <returns>A list of nodes in the template that have the supplied <c>id</c></returns>
        List<XmlNode> ByTestId(string testId);

        /// <summary>
        /// Used to find all matching node in the rendered template where the <c>partial</c>'s <c>name</c> matches the provided parameter value.
        /// </summary>
        /// <example>
        /// Sample template
        /// <code>
        /// <div>
        /// <p data-testId="example-testId">My cool paragraph 😎</p>
        /// <p data-testId="some-other-testId">Try and find me!</p>
        /// <div data-testId="example-testId"><partial name="_examplePartialName"/></div>
        /// <partial name="_examplePartialName"/>
        /// </div>
        /// </code>
        /// Your code
        /// <code>
        /// var nodes = myRenderedArticle.GetAll.ByPartialName("_examplePartialName");
        /// </code>
        /// Returns
        /// <code>
        /// <partial name="_examplePartialName"/>
        /// <partial name="_examplePartialName"/>
        /// </code>
        ///</example>
        /// <param name="partialName"></param>
        /// <returns></returns>
        List<XmlNode> ByPartialName(string partialName);
    }
}