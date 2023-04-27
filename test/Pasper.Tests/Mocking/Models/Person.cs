namespace Pasper.Tests.Mocking.Models;

internal sealed class Person
{
    [Ignored] // Most serializers will ignore readonly properties by default.
              //     We explicitly mark it for testing purposes.
    public string DisplayName => $"{FirstName} {LastName}";

    [Serialized("first_name")]
    public string FirstName { get; set; }

    [Serialized("last_name")]
    public string LastName { get; set; }

    [Serialized("age")]
    public int Age { get; set; }
}
