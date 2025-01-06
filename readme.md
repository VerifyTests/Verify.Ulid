# <img src="/src/icon.png" height="30px"> Verify.Ulid

[![Discussions](https://img.shields.io/badge/Verify-Discussions-yellow?svg=true&label=)](https://github.com/orgs/VerifyTests/discussions)
[![Build status](https://ci.appveyor.com/api/projects/status/ff4ms9mevndkui7l?svg=true)](https://ci.appveyor.com/project/SimonCropp/Verify-Ulid)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.Ulid.svg)](https://www.nuget.org/packages/Verify.Ulid/)

Extends [Verify](https://github.com/VerifyTests/Verify) to enable scrubbing of Universally Unique Lexicographically Sortable Identifiers via [Ulid](https://github.com/Cysharp/Ulid).


**See [Milestones](../../milestones?state=closed) for release notes.**


## NuGet package

https://nuget.org/packages/Verify.Ulid/


## Usage

Call `VerifyUlid.Initialize()` once at assembly load time.

<!-- snippet: Initialize -->
<a id='snippet-Initialize'></a>
```cs
[ModuleInitializer]
public static void Init() =>
    VerifyUlid.Initialize();
```
<sup><a href='/src/Tests/ModuleInitializer.cs#L3-L9' title='Snippet source file'>snippet source</a> | <a href='#snippet-Initialize' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

