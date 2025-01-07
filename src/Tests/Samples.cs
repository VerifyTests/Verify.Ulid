﻿[TestFixture]
public class Samples
{
    [Test]
    public Task Typed()
    {
        var id = Ulid.NewUlid();
        return Verify(id);
    }

    #region Nested

    [Test]
    public Task NestedScrubbing()
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

    #endregion
}

public class Person
{
    public required Ulid Id { get; init; }
    public required string Name { get; init; }
    public required string Description { get; init; }
}