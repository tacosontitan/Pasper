namespace Pasper.Tests;

public class IgnoreTests
{
    [Fact]
    public void NoAttributesFound()
    {
        var provider = new Mocking.MockProvider();
        var input = new { Name = "John", Age = 42 };
        var serialized = provider.Serialize(input);
        
        // TO BE CONTINUED...
    }
}