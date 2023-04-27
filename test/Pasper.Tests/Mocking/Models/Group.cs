using Pasper;

namespace Pasper.Tests.Mocking.Models;

internal sealed class Group
{
    [Ignored]
    public Guid Id { get; set; }

    [Serialized]
    public string Name { get; set; }

    [Serialized]
    public IEnumerable<Person> Members { get; set; }
}