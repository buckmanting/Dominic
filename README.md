<p align="center">
  <a href="https://github.com/springerBuck/Dominic">
    <img src="images/logo.png" alt="Dominic Logo" height="200" width="200">
  </a>

  <h1 align="center">Dominic</h1>

  <p align="center">
    A library for UI testing cshtml 🧪
    <br />
    <a href="https://github.com/springerBuck/Dominic"><strong>Explore the docs 📚 »</strong></a>
    <br />
    <br />
    <a href="https://github.com/springerBuck/Dominic/issues">Report Bug 🐛</a>
    ·
    <a href="https://github.com/springerBuck/Dominic/issues">Request Feature ✨</a>
    ·
    <a href="https://github.com/springerBuck/Dominic/discussions">Start a Discussion 🎙</a>
  </p>
</p>

[![Build and Test](https://github.com/springerBuck/Dominic/actions/workflows/build-and-test.yml/badge.svg)](https://github.com/springerBuck/Dominic/actions/workflows/build-and-test.yml)

## Table of Contents
 - [Installation](#installation)
 - [Configuring your project](#configuring-your-project)
 - [Features](#features)
 - [Philosophy](#philosophy)
 - [Quickstart](#quickstart)
 - [API](#api)
 - [How does it work?](#how-does-it-work?)
 - [How to Contribute](#how-to-Contribute)
 - [Versioning](#versioning)
 - [Acknowledgements](#acknowledgements)
 - [See also](#see-also)
 - [Support](#support)

## Installation
Dominic should be installed in the project containing your tests. You can install it with your favorite NuGet package manager, the `dotnet` cli, `Install-Package` cli or manually adding the reference to our `csproj`.

### Package Manager
`Install-Package Dominic`
### .NET CLI
`dotnet add package Dominic`
### PackageReference
Edit your `csproj` of the project containing your tests, and inside the `<ItemGroup>` add the reference to Dominic. See below for an example.

```XML
<ItemGroup>
    <PackageReference Include="Dominic" Version="1.0.0" />
</ItemGroup>
```

## Configuring your project
Dominic uses [RazorLight](https://github.com/toddams/RazorLight) to render your `cshtml` partials. A requirement of RazorLight is that `PreserveCompilationContext` is set to `true` in your `csproj` of the project where it is used. Failing to configure this will result in an `Exception` being thrown, more details can be found in the [GitHub Issue](https://github.com/toddams/RazorLight/issues/127). See below for an example of how to configure your `csproj`.

```XML
<PropertyGroup>
    ...
    <PreserveCompilationContext>true</PreserveCompilationContext>
    ...
</PropertyGroup>
```

Within the project containing your view models, or any type used within you views, you must set `PreserveCompilationContext` and `PreserveCompilationReferences` to true in the `csproj`. 

```XML
    <PropertyGroup>
        <PreserveCompilationContext>true</PreserveCompilationContext>
        <PreserveCompilationReferences>true</PreserveCompilationReferences>
    </PropertyGroup>
```

## Features
### Rendering templates

### Querying rendered templates

### Configuring the template renderer

## Philosophy
TODO: add details here

## Quickstart
### Example Template
MultipleDuplicateIds.cshtml
```html
<main>
    <div data-testId="my-test-id" class="cool-class-a">My Div One, @Model.TestText</div>
    <div data-testId="my-test-id" class="cool-class-b">My Div Two, @Model.TestText</div>
    <div data-testId="my-test-id" class="cool-class-c">My Div Three, @Model.TestText</div>
    <div data-testId="my-test-id" class="cool-class-d">My Div Four, @Model.TestText</div>
</main>
```

### Example Code
```cs
// test setup, here we configure the location of the views with Template.SetViewLocation()
public MyTests()
{
  var currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory());
  var viewPath = $"{currentDirectory}/TestTemplates";
  Template.SetViewLocation(viewPath);
}

[Fact]
public async Task ByTestId_ItCanGet()
{
  var sut = await Template.Render("MultipleDuplicateIds.cshtml", new {TestText = "Hello World"});
  Assert.Equal(4, sut.GetAll.ByTestId("my-test-id").Count);
}
```


## API
There are four `Getter`s to get elements from the rendered template; `GetOnly`, `GetFirst`, `GetLast` and `GetAll`. Each of these can query the rendered template with the following methods `ById`, `ByType`, `ByTestId` and`ByPartialName`. 

See the [API Documentation](API.md) for further information.

## How does it work?
TODO: add details here

## How to Contribute
Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are greatly appreciated. Before you jump into the code I would recommend you first read our [contribution guidelines](CONTRIBUTING.md). The basic steps are as follows:

1. Open and issue for a Feature ✨ or Bug 🐛
1. Clone the Project `git clone git@github.com:springerBuck/Dominic.git`
1. Create your Feature or Bug Branch `git checkout -b feature/cool-feature` or `git checkout -b bug/pesky-bug`
1. Commit your Changes `git commit -m 'Adds some cool feature'`. Please see the [Springer Nature Frontend Playbook](https://github.com/springernature/frontend-playbook/blob/main/git/git.md#commit-messages) for the expected commit message style.
1. Push to the Branch `git push origin feature/cool-feature`
1. Open a Pull Request

## Versioning
We use Semantic Versioning (Semver) for our versioning. It is a great way to keep our versioning easy to understand. As well as this it allows developers who use Dominic to upgrade to newer versions with confidence that things won't break 🙂. There is a wonderful explanation of and reasoning for Semver over at the [Springer Nature Frontend Playbook](https://github.com/springernature/frontend-playbook/blob/main/git/semver.md).

## License
Distributed under the MIT License. See [`LICENSE`](LICENSE.md) for more information.

## Acknowledgements
TODO: add details here

## See also
TODO: add details here

## Support
TODO: add details here