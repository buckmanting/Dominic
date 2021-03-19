# Dominic 
A library for UI testing cshtml.
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
 - [Acknowledgements](#acknowledgements)
 - [See also](#see-also)
 - [Support](#support)

## Installation
Dominic should be installed in the project coutaining your tests. You can install it with your favourite NuGet package manager, the `dotnet` cli, `Install-Package` cli or manually adding the reference to our `csproj`.

### Package Manager
`Install-Package Dominic`
### .NET CLI
`dotnet add package Dominic`
### PackageReference
Edit the `csproj` of the project containing your tests, and inside the `<ItemGroup>` add the reference to Dominic. See below for an example.

```
<ItemGroup>
    <PackageReference Include="Dominic" Version="1.0.0" />
</ItemGroup>
```

## Configuring your project
Dominic uses [RazorLight](https://github.com/toddams/RazorLight) to render your `cshtml` partials. A requirement of RazorLight is that `PreserveCompilationContext` is set to `true` in the `csproj` of the project where it is used. Failing to configure this will result in an `Exception` being thrown, more details can be found in the [GitHub Issue](https://github.com/toddams/RazorLight/issues/127). See below for an example of how to configure your `csproj`.

```
<PropertyGroup>
    ...
    <PreserveCompilationContext>true</PreserveCompilationContext>
    ...
</PropertyGroup>
  ```

## Features
TODO: add details here

## Philosophy
TODO: add details here

## Quickstart
TODO: add details here

## API
TODO: add details here

## How does it work?
TODO: add details here

## How to Contribute
TODO: add details here

## Acknowledgements
TODO: add details here

## See also
TODO: add details here

## Support
TODO: add details here