<a name='assembly'></a>
# Dominic

## Contents

- [GetAll](#T-Dominic-Getters-GetAll 'Dominic.Getters.GetAll')
  - [ById(id)](#M-Dominic-Getters-GetAll-ById-System-String- 'Dominic.Getters.GetAll.ById(System.String)')
  - [ByPartialName(partialName)](#M-Dominic-Getters-GetAll-ByPartialName-System-String- 'Dominic.Getters.GetAll.ByPartialName(System.String)')
  - [ByTestId(testId)](#M-Dominic-Getters-GetAll-ByTestId-System-String- 'Dominic.Getters.GetAll.ByTestId(System.String)')
  - [ByType(type)](#M-Dominic-Getters-GetAll-ByType-System-String- 'Dominic.Getters.GetAll.ByType(System.String)')
- [GetFirst](#T-Dominic-Getters-GetFirst 'Dominic.Getters.GetFirst')
  - [ById(id)](#M-Dominic-Getters-GetFirst-ById-System-String- 'Dominic.Getters.GetFirst.ById(System.String)')
  - [ByPartialName(partialName)](#M-Dominic-Getters-GetFirst-ByPartialName-System-String- 'Dominic.Getters.GetFirst.ByPartialName(System.String)')
  - [ByTestId(testId)](#M-Dominic-Getters-GetFirst-ByTestId-System-String- 'Dominic.Getters.GetFirst.ByTestId(System.String)')
  - [ByType(type)](#M-Dominic-Getters-GetFirst-ByType-System-String- 'Dominic.Getters.GetFirst.ByType(System.String)')
- [GetLast](#T-Dominic-Getters-GetLast 'Dominic.Getters.GetLast')
  - [ById(id)](#M-Dominic-Getters-GetLast-ById-System-String- 'Dominic.Getters.GetLast.ById(System.String)')
  - [ByPartialName(partialName)](#M-Dominic-Getters-GetLast-ByPartialName-System-String- 'Dominic.Getters.GetLast.ByPartialName(System.String)')
  - [ByTestId(testId)](#M-Dominic-Getters-GetLast-ByTestId-System-String- 'Dominic.Getters.GetLast.ByTestId(System.String)')
  - [ByType(type)](#M-Dominic-Getters-GetLast-ByType-System-String- 'Dominic.Getters.GetLast.ByType(System.String)')
- [GetOnly](#T-Dominic-Getters-GetOnly 'Dominic.Getters.GetOnly')
  - [ById(id)](#M-Dominic-Getters-GetOnly-ById-System-String- 'Dominic.Getters.GetOnly.ById(System.String)')
  - [ByPartialName(partialName)](#M-Dominic-Getters-GetOnly-ByPartialName-System-String- 'Dominic.Getters.GetOnly.ByPartialName(System.String)')
  - [ByTestId(testId)](#M-Dominic-Getters-GetOnly-ByTestId-System-String- 'Dominic.Getters.GetOnly.ByTestId(System.String)')
  - [ByType(type)](#M-Dominic-Getters-GetOnly-ByType-System-String- 'Dominic.Getters.GetOnly.ByType(System.String)')
- [Template](#T-Dominic-Template 'Dominic.Template')
  - [GetAll](#F-Dominic-Template-GetAll 'Dominic.Template.GetAll')
  - [GetFirst](#F-Dominic-Template-GetFirst 'Dominic.Template.GetFirst')
  - [GetLast](#F-Dominic-Template-GetLast 'Dominic.Template.GetLast')
  - [GetOnly](#F-Dominic-Template-GetOnly 'Dominic.Template.GetOnly')
  - [Render(path)](#M-Dominic-Template-Render-System-String- 'Dominic.Template.Render(System.String)')
  - [Render\`\`1(path,model)](#M-Dominic-Template-Render``1-System-String,``0- 'Dominic.Template.Render``1(System.String,``0)')
  - [SetResolver(func)](#M-Dominic-Template-SetResolver-System-Func{System-Type,System-Object}- 'Dominic.Template.SetResolver(System.Func{System.Type,System.Object})')
  - [SetViewLocation(path)](#M-Dominic-Template-SetViewLocation-System-String- 'Dominic.Template.SetViewLocation(System.String)')
- [TooManyElementsFoundException](#T-Dominic-Exceptions-TooManyElementsFoundException 'Dominic.Exceptions.TooManyElementsFoundException')

<a name='T-Dominic-Getters-GetAll'></a>
## GetAll `type`

##### Namespace

Dominic.Getters

<a name='M-Dominic-Getters-GetAll-ById-System-String-'></a>
### ById(id) `method`

##### Summary

Used to find all matching node in the rendered template where the node's `id` matches the provided parameter value.

##### Returns

A list of nodes in the template that have the supplied `id`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | `Id` of the desired nodes |

##### Example

Sample template

```
<div>
  <p id="example-id">
             My cool paragraph 😎
             </p>
  <p>
             Don't try and find me!
             </p>
  <div id="example-id">
             My other cool paragraph 😎
             </div>
</div>
```

Your code

```
var nodes = myRenderedArticle.GetAll.ById("example-id");
```

Returns

```
<p id="example-id">My cool paragraph 😎</p>
```

<a name='M-Dominic-Getters-GetAll-ByPartialName-System-String-'></a>
### ByPartialName(partialName) `method`

##### Summary

Used to find all matching node in the rendered template where the `partial`'s `name` matches the provided parameter value.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| partialName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Example

Sample template

```
<div>
  <p data-testId="example-testId">My cool paragraph 😎</p>
  <p data-testId="some-other-testId">Try and find me!</p>
  <div data-testId="example-testId">
    <partial name="_examplePartialName" />
  </div>
  <partial name="_examplePartialName" />
</div>
```

Your code

```
var nodes = myRenderedArticle.GetAll.ByPartialName("_examplePartialName");
```

Returns

```
<partial name="_examplePartialName" />
```

<a name='M-Dominic-Getters-GetAll-ByTestId-System-String-'></a>
### ByTestId(testId) `method`

##### Summary

Used to find all matching node in the rendered template where the node's `data-testId` attribute matches the provided parameter value.

##### Returns

A list of nodes in the template that have the supplied `id`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| testId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | `data-testId` attribute value of the desired nodes |

##### Example

Sample template

```
<div>
  <p data-testId="example-testId">
             My cool paragraph 😎
             </p>
  <p data-testId="some-other-testId">
             Try and find me!
             </p>
  <div data-testId="example-testId">
             My other cool paragraph 😎
             </div>
</div>
```

Your code

```
var nodes = myRenderedArticle.GetAll.ByTestId("example-testId");
```

Returns

```
<p data-testId="example-testId">
                 My cool paragraph 😎
             </p>
```

<a name='M-Dominic-Getters-GetAll-ByType-System-String-'></a>
### ByType(type) `method`

##### Summary

Used to find all matching node in the rendered template where the node's `type` matches the provided parameter value.

##### Returns

A list of nodes in the template that have the supplied `id`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | `type` of the desired nodes, for example `div`, `main`, `p` |

##### Example

Sample template

```
<div>
  <p>
             My cool paragraph 😎
             </p>
  <p>
             Try and find me!
             </p>
  <div>
             My other cool paragraph 😎
             </div>
</div>
```

Your code

```
var nodes = myRenderedArticle.GetAll.ByType("p");
```

Returns

```
<p>
                 My cool paragraph 😎
             </p>
```

<a name='T-Dominic-Getters-GetFirst'></a>
## GetFirst `type`

##### Namespace

Dominic.Getters

<a name='M-Dominic-Getters-GetFirst-ById-System-String-'></a>
### ById(id) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Dominic-Getters-GetFirst-ByPartialName-System-String-'></a>
### ByPartialName(partialName) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| partialName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Dominic-Getters-GetFirst-ByTestId-System-String-'></a>
### ByTestId(testId) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| testId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Dominic-Getters-GetFirst-ByType-System-String-'></a>
### ByType(type) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Dominic-Getters-GetLast'></a>
## GetLast `type`

##### Namespace

Dominic.Getters

<a name='M-Dominic-Getters-GetLast-ById-System-String-'></a>
### ById(id) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Dominic-Getters-GetLast-ByPartialName-System-String-'></a>
### ByPartialName(partialName) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| partialName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Dominic-Getters-GetLast-ByTestId-System-String-'></a>
### ByTestId(testId) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| testId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Dominic-Getters-GetLast-ByType-System-String-'></a>
### ByType(type) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Dominic-Getters-GetOnly'></a>
## GetOnly `type`

##### Namespace

Dominic.Getters

<a name='M-Dominic-Getters-GetOnly-ById-System-String-'></a>
### ById(id) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Dominic.Exceptions.TooManyElementsFoundException](#T-Dominic-Exceptions-TooManyElementsFoundException 'Dominic.Exceptions.TooManyElementsFoundException') |  |

<a name='M-Dominic-Getters-GetOnly-ByPartialName-System-String-'></a>
### ByPartialName(partialName) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| partialName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Dominic.Exceptions.TooManyElementsFoundException](#T-Dominic-Exceptions-TooManyElementsFoundException 'Dominic.Exceptions.TooManyElementsFoundException') |  |

<a name='M-Dominic-Getters-GetOnly-ByTestId-System-String-'></a>
### ByTestId(testId) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| testId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Dominic.Exceptions.TooManyElementsFoundException](#T-Dominic-Exceptions-TooManyElementsFoundException 'Dominic.Exceptions.TooManyElementsFoundException') |  |

<a name='M-Dominic-Getters-GetOnly-ByType-System-String-'></a>
### ByType(type) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Dominic.Exceptions.TooManyElementsFoundException](#T-Dominic-Exceptions-TooManyElementsFoundException 'Dominic.Exceptions.TooManyElementsFoundException') |  |

<a name='T-Dominic-Template'></a>
## Template `type`

##### Namespace

Dominic

<a name='F-Dominic-Template-GetAll'></a>
### GetAll `constants`

##### Summary

[GetAll](#T-Dominic-Getters-GetAll 'Dominic.Getters.GetAll')

<a name='F-Dominic-Template-GetFirst'></a>
### GetFirst `constants`

##### Summary

[GetFirst](#T-Dominic-Getters-GetFirst 'Dominic.Getters.GetFirst')

<a name='F-Dominic-Template-GetLast'></a>
### GetLast `constants`

##### Summary

[GetLast](#T-Dominic-Getters-GetLast 'Dominic.Getters.GetLast')

<a name='F-Dominic-Template-GetOnly'></a>
### GetOnly `constants`

##### Summary

[GetOnly](#T-Dominic-Getters-GetOnly 'Dominic.Getters.GetOnly')

<a name='M-Dominic-Template-Render-System-String-'></a>
### Render(path) `method`

##### Summary



##### Returns

A new instance of a rendered template, which can be queried.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Path of the view you wish to test, relative to the path configured with [SetViewLocation](#M-Dominic-Template-SetViewLocation-System-String- 'Dominic.Template.SetViewLocation(System.String)') |

##### Example

```
Template myRenderedArticle = await Template.Render("MySimpleTemplate.cshtml");
```

<a name='M-Dominic-Template-Render``1-System-String,``0-'></a>
### Render\`\`1(path,model) `method`

##### Summary



##### Returns

A new instance of a rendered template, which can be queried.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Path of the view you wish to test, relative to the path configured with [SetViewLocation](#M-Dominic-Template-SetViewLocation-System-String- 'Dominic.Template.SetViewLocation(System.String)') |
| model | [\`\`0](#T-``0 '``0') | View Model of the view you wish to test |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the View Model |

##### Example

```
Template myRenderedArticle = await Template.Render(
    "MyArticle.cshtml",
    new Article {Title = "My title", Author = "Aaron Buckley"}
);
```

<a name='M-Dominic-Template-SetResolver-System-Func{System-Type,System-Object}-'></a>
### SetResolver(func) `method`

##### Summary

TODO add documentation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| func | [System.Func{System.Type,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Type,System.Object}') |  |

<a name='M-Dominic-Template-SetViewLocation-System-String-'></a>
### SetViewLocation(path) `method`

##### Summary



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Root path of the views |

<a name='T-Dominic-Exceptions-TooManyElementsFoundException'></a>
## TooManyElementsFoundException `type`

##### Namespace

Dominic.Exceptions

##### Summary


