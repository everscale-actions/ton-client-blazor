![Main workflow](https://github.com/ton-actions/ton-client-blazor/workflows/Main%20workflow/badge.svg)
[<img src="https://avatars3.githubusercontent.com/u/67861283?s=150&u=4536b61595a1b422604fab8a7012092d891278f6&v=4" align="right" width="150">](https://freeton.org/)

# ⚠️ The project is no longer supported ⚠️

This is package is depricated take a look for Everscale .Net with Blazor WASM Adpater 

https://github.com/everscale-actions/everscale-dotnet

# TonClientBlazor

This is amazing! Blazor in love with Free TON now!

Do you want build client web apps with C#? 

Revolution is comming. Microsoft .NET Conf 2020 includes about fifteen presentation connected with Blazor and Blazor Webassembly. 

And now we can connect it with Free TON network 🌟

# Usage

### Create you app folder

```
mkdir BlazorTon
cd BlazorTon
```

### Create solution and project

```
dotnet new sln
dotnet new blazorwasm
dotnet sln add .\BlazorTon.csproj
```

### Add Blazor TONClient

```
dotnet add package ch1seL.TonClientBlazor
```

### Edit Program.cs and add line to services registration

```
builder.Services.AddTonClient();
```

### Edit wwwroot\index.html and add js script to end of the body section

```
<script src="_content/ch1seL.TonClientBlazor/js/tonclient.js"></script>
```

### Inject TonClient where you need

```
[Inject]
ITonClient TonClient { get; set; }
```

# Demo

https://ton-actions.github.io/ton-client-blazor/

# Sample from Demo site

https://github.com/ton-actions/ton-client-blazor/tree/master/samples/WebApplication
