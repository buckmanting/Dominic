<a name='assembly'></a>
# Dominic

## Contents

- [DominicConfiguration](#T-Dominic-DominicConfiguration 'Dominic.DominicConfiguration')
  - [Resolver](#F-Dominic-DominicConfiguration-Resolver 'Dominic.DominicConfiguration.Resolver')
  - [ViewFolderLocation](#F-Dominic-DominicConfiguration-ViewFolderLocation 'Dominic.DominicConfiguration.ViewFolderLocation')
- [GetAll](#T-Dominic-Getters-GetAll 'Dominic.Getters.GetAll')
  - [ById(id)](#M-Dominic-Getters-GetAll-ById-System-String- 'Dominic.Getters.GetAll.ById(System.String)')
  - [ByPartialName(partialName)](#M-Dominic-Getters-GetAll-ByPartialName-System-String- 'Dominic.Getters.GetAll.ByPartialName(System.String)')
  - [ByTestId(testId)](#M-Dominic-Getters-GetAll-ByTestId-System-String- 'Dominic.Getters.GetAll.ByTestId(System.String)')
  - [ByType(type)](#M-Dominic-Getters-GetAll-ByType-System-String- 'Dominic.Getters.GetAll.ByType(System.String)')
- [GetFirst](#T-Dominic-Getters-GetFirst 'Dominic.Getters.GetFirst')
  - [ByAspAction(aspAction)](#M-Dominic-Getters-GetFirst-ByAspAction-System-String- 'Dominic.Getters.GetFirst.ByAspAction(System.String)')
  - [ByAspController(aspController)](#M-Dominic-Getters-GetFirst-ByAspController-System-String- 'Dominic.Getters.GetFirst.ByAspController(System.String)')
  - [ByAspFor(aspFor)](#M-Dominic-Getters-GetFirst-ByAspFor-System-String- 'Dominic.Getters.GetFirst.ByAspFor(System.String)')
  - [ById(id)](#M-Dominic-Getters-GetFirst-ById-System-String- 'Dominic.Getters.GetFirst.ById(System.String)')
  - [ByPartialName(partialName)](#M-Dominic-Getters-GetFirst-ByPartialName-System-String- 'Dominic.Getters.GetFirst.ByPartialName(System.String)')
  - [ByTestId(testId)](#M-Dominic-Getters-GetFirst-ByTestId-System-String- 'Dominic.Getters.GetFirst.ByTestId(System.String)')
  - [ByType(type)](#M-Dominic-Getters-GetFirst-ByType-System-String- 'Dominic.Getters.GetFirst.ByType(System.String)')
- [GetLast](#T-Dominic-Getters-GetLast 'Dominic.Getters.GetLast')
  - [ByAspAction(aspAction)](#M-Dominic-Getters-GetLast-ByAspAction-System-String- 'Dominic.Getters.GetLast.ByAspAction(System.String)')
  - [ByAspController(aspController)](#M-Dominic-Getters-GetLast-ByAspController-System-String- 'Dominic.Getters.GetLast.ByAspController(System.String)')
  - [ByAspFor(aspFor)](#M-Dominic-Getters-GetLast-ByAspFor-System-String- 'Dominic.Getters.GetLast.ByAspFor(System.String)')
  - [ById(id)](#M-Dominic-Getters-GetLast-ById-System-String- 'Dominic.Getters.GetLast.ById(System.String)')
  - [ByPartialName(partialName)](#M-Dominic-Getters-GetLast-ByPartialName-System-String- 'Dominic.Getters.GetLast.ByPartialName(System.String)')
  - [ByTestId(testId)](#M-Dominic-Getters-GetLast-ByTestId-System-String- 'Dominic.Getters.GetLast.ByTestId(System.String)')
  - [ByType(type)](#M-Dominic-Getters-GetLast-ByType-System-String- 'Dominic.Getters.GetLast.ByType(System.String)')
- [GetOnly](#T-Dominic-Getters-GetOnly 'Dominic.Getters.GetOnly')
  - [ByAspAction(aspAction)](#M-Dominic-Getters-GetOnly-ByAspAction-System-String- 'Dominic.Getters.GetOnly.ByAspAction(System.String)')
  - [ByAspController(aspController)](#M-Dominic-Getters-GetOnly-ByAspController-System-String- 'Dominic.Getters.GetOnly.ByAspController(System.String)')
  - [ByAspFor(aspFor)](#M-Dominic-Getters-GetOnly-ByAspFor-System-String- 'Dominic.Getters.GetOnly.ByAspFor(System.String)')
  - [ById(id)](#M-Dominic-Getters-GetOnly-ById-System-String- 'Dominic.Getters.GetOnly.ById(System.String)')
  - [ByPartialName(partialName)](#M-Dominic-Getters-GetOnly-ByPartialName-System-String- 'Dominic.Getters.GetOnly.ByPartialName(System.String)')
  - [ByTestId(testId)](#M-Dominic-Getters-GetOnly-ByTestId-System-String- 'Dominic.Getters.GetOnly.ByTestId(System.String)')
  - [ByType(type)](#M-Dominic-Getters-GetOnly-ByType-System-String- 'Dominic.Getters.GetOnly.ByType(System.String)')
- [ISelectorMany](#T-Dominic-Getters-ISelectorMany 'Dominic.Getters.ISelectorMany')
  - [ById(id)](#M-Dominic-Getters-ISelectorMany-ById-System-String- 'Dominic.Getters.ISelectorMany.ById(System.String)')
  - [ByPartialName(partialName)](#M-Dominic-Getters-ISelectorMany-ByPartialName-System-String- 'Dominic.Getters.ISelectorMany.ByPartialName(System.String)')
  - [ByTestId(testId)](#M-Dominic-Getters-ISelectorMany-ByTestId-System-String- 'Dominic.Getters.ISelectorMany.ByTestId(System.String)')
  - [ByType(type)](#M-Dominic-Getters-ISelectorMany-ByType-System-String- 'Dominic.Getters.ISelectorMany.ByType(System.String)')
- [ISelectorSingle](#T-Dominic-Getters-ISelectorSingle 'Dominic.Getters.ISelectorSingle')
  - [ByAspAction(aspAction)](#M-Dominic-Getters-ISelectorSingle-ByAspAction-System-String- 'Dominic.Getters.ISelectorSingle.ByAspAction(System.String)')
  - [ByAspController(aspController)](#M-Dominic-Getters-ISelectorSingle-ByAspController-System-String- 'Dominic.Getters.ISelectorSingle.ByAspController(System.String)')
  - [ByAspFor(aspFor)](#M-Dominic-Getters-ISelectorSingle-ByAspFor-System-String- 'Dominic.Getters.ISelectorSingle.ByAspFor(System.String)')
  - [ById(id)](#M-Dominic-Getters-ISelectorSingle-ById-System-String- 'Dominic.Getters.ISelectorSingle.ById(System.String)')
  - [ByPartialName(partialName)](#M-Dominic-Getters-ISelectorSingle-ByPartialName-System-String- 'Dominic.Getters.ISelectorSingle.ByPartialName(System.String)')
  - [ByTestId(testId)](#M-Dominic-Getters-ISelectorSingle-ByTestId-System-String- 'Dominic.Getters.ISelectorSingle.ByTestId(System.String)')
  - [ByType(type)](#M-Dominic-Getters-ISelectorSingle-ByType-System-String- 'Dominic.Getters.ISelectorSingle.ByType(System.String)')
- [ItemNotFoundException](#T-Dominic-Exceptions-ItemNotFoundException 'Dominic.Exceptions.ItemNotFoundException')
- [Template](#T-Dominic-Template 'Dominic.Template')
  - [GetAll](#F-Dominic-Template-GetAll 'Dominic.Template.GetAll')
  - [GetFirst](#F-Dominic-Template-GetFirst 'Dominic.Template.GetFirst')
  - [GetLast](#F-Dominic-Template-GetLast 'Dominic.Template.GetLast')
  - [GetOnly](#F-Dominic-Template-GetOnly 'Dominic.Template.GetOnly')
  - [Render(path,configuration,viewData)](#M-Dominic-Template-Render-System-String,Dominic-DominicConfiguration,System-Dynamic-ExpandoObject- 'Dominic.Template.Render(System.String,Dominic.DominicConfiguration,System.Dynamic.ExpandoObject)')
  - [Render\`\`1(path,configuration,model,viewData)](#M-Dominic-Template-Render``1-System-String,Dominic-DominicConfiguration,``0,System-Dynamic-ExpandoObject- 'Dominic.Template.Render``1(System.String,Dominic.DominicConfiguration,``0,System.Dynamic.ExpandoObject)')
- [TooManyElementsFoundException](#T-Dominic-Exceptions-TooManyElementsFoundException 'Dominic.Exceptions.TooManyElementsFoundException')

<a name='T-Dominic-DominicConfiguration'></a>
## DominicConfiguration `type`

##### Namespace

Dominic

<a name='F-Dominic-DominicConfiguration-Resolver'></a>
### Resolver `constants`

##### Summary



<a name='F-Dominic-DominicConfiguration-ViewFolderLocation'></a>
### ViewFolderLocation `constants`

##### Summary



##### Returns



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
<p data-testId="example-testId">My cool paragraph 😎</p>
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
<p>My cool paragraph 😎</p>
```

<a name='T-Dominic-Getters-GetFirst'></a>
## GetFirst `type`

##### Namespace

Dominic.Getters

<a name='M-Dominic-Getters-GetFirst-ByAspAction-System-String-'></a>
### ByAspAction(aspAction) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| aspAction | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') |  |

<a name='M-Dominic-Getters-GetFirst-ByAspController-System-String-'></a>
### ByAspController(aspController) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| aspController | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') |  |

<a name='M-Dominic-Getters-GetFirst-ByAspFor-System-String-'></a>
### ByAspFor(aspFor) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| aspFor | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') |  |

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

<a name='M-Dominic-Getters-GetLast-ByAspAction-System-String-'></a>
### ByAspAction(aspAction) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| aspAction | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') |  |

<a name='M-Dominic-Getters-GetLast-ByAspController-System-String-'></a>
### ByAspController(aspController) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| aspController | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') |  |

<a name='M-Dominic-Getters-GetLast-ByAspFor-System-String-'></a>
### ByAspFor(aspFor) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| aspFor | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') |  |

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

<a name='M-Dominic-Getters-GetOnly-ByAspAction-System-String-'></a>
### ByAspAction(aspAction) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| aspAction | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Dominic.Exceptions.TooManyElementsFoundException](#T-Dominic-Exceptions-TooManyElementsFoundException 'Dominic.Exceptions.TooManyElementsFoundException') |  |

<a name='M-Dominic-Getters-GetOnly-ByAspController-System-String-'></a>
### ByAspController(aspController) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| aspController | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Dominic.Exceptions.TooManyElementsFoundException](#T-Dominic-Exceptions-TooManyElementsFoundException 'Dominic.Exceptions.TooManyElementsFoundException') |  |

<a name='M-Dominic-Getters-GetOnly-ByAspFor-System-String-'></a>
### ByAspFor(aspFor) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| aspFor | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Dominic.Exceptions.TooManyElementsFoundException](#T-Dominic-Exceptions-TooManyElementsFoundException 'Dominic.Exceptions.TooManyElementsFoundException') |  |

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

<a name='T-Dominic-Getters-ISelectorMany'></a>
## ISelectorMany `type`

##### Namespace

Dominic.Getters

<a name='M-Dominic-Getters-ISelectorMany-ById-System-String-'></a>
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

<a name='M-Dominic-Getters-ISelectorMany-ByPartialName-System-String-'></a>
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

<a name='M-Dominic-Getters-ISelectorMany-ByTestId-System-String-'></a>
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
<p data-testId="example-testId">My cool paragraph 😎</p>
```

<a name='M-Dominic-Getters-ISelectorMany-ByType-System-String-'></a>
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
<p>My cool paragraph 😎</p>
```

<a name='T-Dominic-Getters-ISelectorSingle'></a>
## ISelectorSingle `type`

##### Namespace

Dominic.Getters

<a name='M-Dominic-Getters-ISelectorSingle-ByAspAction-System-String-'></a>
### ByAspAction(aspAction) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| aspAction | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Dominic.Exceptions.TooManyElementsFoundException](#T-Dominic-Exceptions-TooManyElementsFoundException 'Dominic.Exceptions.TooManyElementsFoundException') |  |

<a name='M-Dominic-Getters-ISelectorSingle-ByAspController-System-String-'></a>
### ByAspController(aspController) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| aspController | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Dominic.Exceptions.TooManyElementsFoundException](#T-Dominic-Exceptions-TooManyElementsFoundException 'Dominic.Exceptions.TooManyElementsFoundException') |  |

<a name='M-Dominic-Getters-ISelectorSingle-ByAspFor-System-String-'></a>
### ByAspFor(aspFor) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| aspFor | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Dominic.Exceptions.TooManyElementsFoundException](#T-Dominic-Exceptions-TooManyElementsFoundException 'Dominic.Exceptions.TooManyElementsFoundException') |  |

<a name='M-Dominic-Getters-ISelectorSingle-ById-System-String-'></a>
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

<a name='M-Dominic-Getters-ISelectorSingle-ByPartialName-System-String-'></a>
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

<a name='M-Dominic-Getters-ISelectorSingle-ByTestId-System-String-'></a>
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

<a name='M-Dominic-Getters-ISelectorSingle-ByType-System-String-'></a>
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

<a name='T-Dominic-Exceptions-ItemNotFoundException'></a>
## ItemNotFoundException `type`

##### Namespace

Dominic.Exceptions

##### Summary



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

<a name='M-Dominic-Template-Render-System-String,Dominic-DominicConfiguration,System-Dynamic-ExpandoObject-'></a>
### Render(path,configuration,viewData) `method`

##### Summary



##### Returns

A new instance of a rendered template, which can be queried.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Path of the view you wish to test, relative to the path configured with [](#!-SetViewLocation 'SetViewLocation') |
| configuration | [Dominic.DominicConfiguration](#T-Dominic-DominicConfiguration 'Dominic.DominicConfiguration') | Configuration for the render engine to start up with |
| viewData | [System.Dynamic.ExpandoObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Dynamic.ExpandoObject 'System.Dynamic.ExpandoObject') |  |

##### Example

```
Template myRenderedArticle = await Template.Render("MySimpleTemplate.cshtml");
```

<a name='M-Dominic-Template-Render``1-System-String,Dominic-DominicConfiguration,``0,System-Dynamic-ExpandoObject-'></a>
### Render\`\`1(path,configuration,model,viewData) `method`

##### Summary



##### Returns

A new instance of a rendered template, which can be queried.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Path of the view you wish to test, relative to the path configured with [](#!-SetViewLocation 'SetViewLocation') |
| configuration | [Dominic.DominicConfiguration](#T-Dominic-DominicConfiguration 'Dominic.DominicConfiguration') | Configuration for the render engine to start up with |
| model | [\`\`0](#T-``0 '``0') | View Model of the view you wish to test |
| viewData | [System.Dynamic.ExpandoObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Dynamic.ExpandoObject 'System.Dynamic.ExpandoObject') |  |

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

<a name='T-Dominic-Exceptions-TooManyElementsFoundException'></a>
## TooManyElementsFoundException `type`

##### Namespace

Dominic.Exceptions

##### Summary


