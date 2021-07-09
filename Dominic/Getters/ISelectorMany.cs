using System.Collections.Generic;
using System.Xml;
using Dominic.Models;

namespace Dominic.Getters
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISelectorMany
    {
        ///  <summary>
        ///  Used to find all matching node in the rendered template where the node's <c>id</c> matches the provided parameter value.
        ///  </summary>
        ///  <example>
        ///  Sample template
        ///  <code>
        ///  <div>
        ///  <p id="example-id">
        ///  My cool paragraph 😎
        ///  </p>
        ///  <p>
        ///  Don't try and find me!
        ///  </p>
        ///  <div id="example-id">
        ///  My other cool paragraph 😎
        ///  </div>
        ///  </div>
        ///  </code>
        ///  Your code
        ///  <code>
        ///  var nodes = myRenderedArticle.GetAll.ById("example-id");
        ///  </code>
        ///  Returns
        ///  <code>
        ///  <p id="example-id">My cool paragraph 😎</p>
        ///  <div id="example-id">My other cool paragraph 😎</div>
        ///  </code>
        /// </example>
        ///  <param name="id"><c>Id</c> of the desired nodes</param>
        ///  <returns>A list of nodes in the template that have the supplied <c>id</c></returns>
        List<Element> ById(string id);

        ///  <summary>
        ///  Used to find all matching node in the rendered template where the node's <c>type</c> matches the provided parameter value.
        ///  </summary>
        ///  <example>
        ///  Sample template
        ///  <code>
        ///  <div>
        ///  <p>
        ///  My cool paragraph 😎
        ///  </p>
        ///  <p>
        ///  Try and find me!
        ///  </p>
        ///  <div>
        ///  My other cool paragraph 😎
        ///  </div>
        ///  </div>
        ///  </code>
        ///  Your code
        ///  <code>
        ///  var nodes = myRenderedArticle.GetAll.ByType("p");
        ///  </code>
        ///  Returns
        ///  <code>
        ///  <p>My cool paragraph 😎</p>
        ///  <p>Try and find me!</p>
        ///  </code>
        /// </example>
        ///  <param name="type"><c>type</c> of the desired nodes, for example <c>div</c>, <c>main</c>, <c>p</c></param>
        ///  <returns>A list of nodes in the template that have the supplied <c>id</c></returns>
        List<Element> ByType(string type);

        ///  <summary>
        ///  Used to find all matching node in the rendered template where the node's <c>data-testId</c> attribute matches the provided parameter value.
        ///  </summary>
        ///  <example>
        ///  Sample template
        ///  <code>
        ///  <div>
        ///  <p data-testId="example-testId">
        ///  My cool paragraph 😎
        ///  </p>
        ///  <p data-testId="some-other-testId">
        ///  Try and find me!
        ///  </p>
        ///  <div data-testId="example-testId">
        ///  My other cool paragraph 😎
        ///  </div>
        ///  </div>
        ///  </code>
        ///  Your code
        ///  <code>
        ///  var nodes = myRenderedArticle.GetAll.ByTestId("example-testId");
        ///  </code>
        ///  Returns
        ///  <code>
        ///  <p data-testId="example-testId">My cool paragraph 😎</p>
        ///  <div data-testId="example-testId">My other cool paragraph 😎</div>
        ///  </code>
        /// </example>
        ///  <param name="testId"><c>data-testId</c> attribute value of the desired nodes</param>
        ///  <returns>A list of nodes in the template that have the supplied <c>id</c></returns>
        List<Element> ByTestId(string testId);

        ///  <summary>
        ///  Used to find all matching node in the rendered template where the <c>partial</c>'s <c>name</c> matches the provided parameter value.
        ///  </summary>
        ///  <example>
        ///  Sample template
        ///  <code>
        ///  <div>
        ///  <p data-testId="example-testId">My cool paragraph 😎</p>
        ///  <p data-testId="some-other-testId">Try and find me!</p>
        ///  <div data-testId="example-testId"><partial name="_examplePartialName"/></div>
        ///  <partial name="_examplePartialName"/>
        ///  </div>
        ///  </code>
        ///  Your code
        ///  <code>
        ///  var nodes = myRenderedArticle.GetAll.ByPartialName("_examplePartialName");
        ///  </code>
        ///  Returns
        ///  <code>
        ///  <partial name="_examplePartialName"/>
        ///  <partial name="_examplePartialName"/>
        ///  </code>
        /// </example>
        ///  <param name="partialName"><c>name</c> attribute value of the desired partial nodes</param>
        ///  <returns>A list of nodes in the template that have the supplied <c>partialName</c></returns>
        List<Element> ByPartialName(string partialName);

        /// <summary>
        /// Used to find all matching node in the rendered template where the node's <c>asp-for</c> attribute matches the provided parameter value.
        /// </summary>
        /// <example>
        /// Sample template
        /// <code>
        /// <div>
        /// <form asp-controller="MyController" asp-action="MyFormAction">
        /// <label asp-for="Name">Name</label>
        /// <input asp-for="Name"/>
        /// <label asp-for="Email">Email</label>
        /// <input asp-for="Email"/>
        /// <label asp-for="Age">Age</label>
        /// <input asp-for="Age"/>
        /// </form>
        /// </code>
        /// Your code
        /// <code>
        /// var nodes = myRenderedArticle.GetAll.ByAspFor("Name");
        /// </code>
        /// Returns
        /// <code>
        /// <label asp-for="Name">Name</label>
        /// <input asp-for="Name"/>
        /// </code>
        /// </example>
        /// <param name="aspFor"><c>asp-for</c> attribute value of the desired nodes</param>
        /// <returns>A list of nodes in the template that have the supplied <c>aspFor</c></returns>
        List<Element> ByAspFor(string aspFor);

        /// <summary>
        /// Used to find all matching node in the rendered template where the node's <c>asp-action</c> attribute matches the provided parameter value.
        /// </summary>
        /// <example>
        /// Sample template
        /// <code>
        /// <div>
        /// <p data-testId="example-testId">My cool paragraph 😎</p>
        /// <p data-testId="some-other-testId">Try and find me!</p>
        /// <div data-testId="example-testId">
        /// <a asp-controller="MyController" asp-action="MyAction">This is cool</a>
        /// <a asp-controller="MyController" asp-action="MyOtherAction">This is the coolest</a>
        /// <a asp-controller="MyController" asp-action="MyAction">But Don't forget this</a>
        /// </div>
        /// </code>
        /// Your code
        /// <code>
        /// var nodes = myRenderedArticle.GetAll.ByAspAction("MyAction");
        /// </code>
        /// Returns
        /// <code>
        /// <a asp-controller="MyController" asp-action="MyAction">This is cool</a>
        /// <a asp-controller="MyController" asp-action="MyAction">But Don't forget this</a>
        /// </code>
        /// </example>
        /// <param name="aspAction"><c>asp-action</c> attribute value of the desired nodes</param>
        /// <returns>A list of nodes in the template that have the supplied <c>aspAction</c></returns>
        List<Element> ByAspAction(string aspAction);

        /// <summary>
        /// Used to find all matching node in the rendered template where the node's <c>asp-controller</c> attribute matches the provided parameter value.
        /// </summary>
        /// <example>
        /// Sample template
        /// <code>
        /// <div>
        /// <p data-testId="example-testId">My cool paragraph 😎</p>
        /// <p data-testId="some-other-testId">Try and find me!</p>
        /// <div data-testId="example-testId">
        /// <a asp-controller="MyController" asp-action="MyAction">This is cool</a>
        /// <a asp-controller="MyController" asp-action="MyOtherAction">This is the coolest</a>
        /// <a asp-controller="MyController" asp-action="MyAction">But Don't forget this</a>
        /// </div>
        /// </code>
        /// Your code
        /// <code>
        /// var nodes = myRenderedArticle.GetAll.ByAspController("MyController");
        /// </code>
        /// Returns
        /// <code>
        /// <a asp-controller="MyController" asp-action="MyAction">This is cool</a>
        /// <a asp-controller="MyController" asp-action="MyOtherAction">This is the coolest</a>
        /// <a asp-controller="MyController" asp-action="MyAction">But Don't forget this</a>
        /// </code>
        /// </example>
        /// <param name="aspController"><c>asp-controller</c> attribute value of the desired nodes</param>
        /// <returns>A list of nodes in the template that have the supplied <c>aspController</c></returns>
        List<Element> ByAspController(string aspController);
    }
}