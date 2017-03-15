[![Nuget](http://img.shields.io/nuget/v/FubuMVC.StructureMap4.svg?style=flat)](http://www.nuget.org/packages/FubuMVC.StructureMap4/)

FubuMVC 1.x StructureMap 4.x Integration
=============

This library integrates FubuMVC 1.x with StructureMap 4.x.

Install
------------

This library can be found on nuget:

    PM> Install-Package FubuMVC.StructureMap4

Configuration
------------

StructureMap can be initialized with the `StructureMap` extension method as follows:

```csharpusing FubuMVC.Core;using FubuMVC.StructureMap4;using StructureMap;[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Bootstrap), nameof(Bootstrap.Start))]public class Bootstrap{    public static void Start()    {        FubuApplication.For<MyFubuRegistry>()            .StructureMap(new Container(x => x.AddRegistry<MyRegistry>()))            .Bootstrap();        ...    }}
```