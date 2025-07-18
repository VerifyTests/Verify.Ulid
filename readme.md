# <img src="/src/icon.png" height="30px"> Verify.Ulid

[![Discussions](https://img.shields.io/badge/Verify-Discussions-yellow?svg=true&label=)](https://github.com/orgs/VerifyTests/discussions)
[![Build status](https://ci.appveyor.com/api/projects/status/soell7l73pbakm8u?svg=true)](https://ci.appveyor.com/project/SimonCropp/Verify-Ulid)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.Ulid.svg)](https://www.nuget.org/packages/Verify.Ulid/)

Extends [Verify](https://github.com/VerifyTests/Verify) to enable scrubbing of Universally Unique Lexicographically Sortable Identifiers via [Ulid](https://github.com/Cysharp/Ulid) package.<!-- singleLineInclude: intro. path: /docs/intro.include.md -->

**See [Milestones](../../milestones?state=closed) for release notes.**


## Sponsors


### Entity Framework Extensions<!-- include: zzz. path: /docs/zzz.include.md -->

[Entity Framework Extensions](https://entityframework-extensions.net/?utm_source=simoncropp&utm_medium=Verify.Ulid) is a major sponsor and is proud to contribute to the development this project.

[![Entity Framework Extensions](https://raw.githubusercontent.com/VerifyTests/Verify.Ulid/refs/heads/main/docs/zzz.png)](https://entityframework-extensions.net/?utm_source=simoncropp&utm_medium=Verify.Ulid)<!-- endInclude -->


## NuGet

 * https://nuget.org/packages/Verify.Ulid


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


ULIDs will then be scrubbed:

<!-- snippet: Nested -->
<a id='snippet-Nested'></a>
```cs
[Test]
public Task UlidScrubbing()
{
    var id = Ulid.NewUlid();
    var target = new Person
    {
        Id = id,
        Name = "Sarah",
        Description = $"Sarah ({id})"
    };
    return Verify(target);
}
```
<sup><a href='/src/Tests/Samples.cs#L93-L108' title='Snippet source file'>snippet source</a> | <a href='#snippet-Nested' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

Result:

<!-- snippet: Samples.UlidScrubbing.verified.txt -->
<a id='snippet-Samples.UlidScrubbing.verified.txt'></a>
```txt
{
  Id: Ulid_1,
  Name: Sarah,
  Description: Sarah (Ulid_1)
}
```
<sup><a href='/src/Tests/Samples.UlidScrubbing.verified.txt#L1-L5' title='Snippet source file'>snippet source</a> | <a href='#snippet-Samples.UlidScrubbing.verified.txt' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


## Disabling Scrubbing

To disable scrubbing use `DontScrubUlids()`

<!-- snippet: DontScrub -->
<a id='snippet-DontScrub'></a>
```cs
[Test]
public Task DontScrubFluent()
{
    var id = Ulid.Parse("01JGXG0GDGQEP47CBQ65E50HYH");
    var target = new Person
    {
        Id = id,
        Name = "Sarah",
        Description = $"Sarah ({id})"
    };
    return Verify(target)
        .DontScrubUlids();
}

[Test]
public Task DontScrubInstance()
{
    var id = Ulid.Parse("01JGXG0GDGQEP47CBQ65E50HYH");
    var target = new Person
    {
        Id = id,
        Name = "Sarah",
        Description = $"Sarah ({id})"
    };
    var settings = new VerifySettings();
    settings.DontScrubUlids();
    return Verify(target, settings);
}
```
<sup><a href='/src/Tests/Samples.cs#L60-L91' title='Snippet source file'>snippet source</a> | <a href='#snippet-DontScrub' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

Result: 

<!-- snippet: Samples.DontScrubInstance.verified.txt -->
<a id='snippet-Samples.DontScrubInstance.verified.txt'></a>
```txt
{
  Id: 01JGXG0GDGQEP47CBQ65E50HYH,
  Name: Sarah,
  Description: Sarah (01JGXG0GDGQEP47CBQ65E50HYH)
}
```
<sup><a href='/src/Tests/Samples.DontScrubInstance.verified.txt#L1-L5' title='Snippet source file'>snippet source</a> | <a href='#snippet-Samples.DontScrubInstance.verified.txt' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


## Icon

[Pattern](https://thenounproject.com/icon/pattern-7353536/) designed by [Mohamed Salah Hajji](https://thenounproject.com/creator/hajjisaleh.mohamed24/) from [The Noun Project](https://thenounproject.com).
