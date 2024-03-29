using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class PropertyNameTests
{
    [Fact]
    public void Value_ShouldBeKey()
    {
        const string expected = "key";
        var token = new PropertyName(expected);
        Assert.Equal(expected, token.Value);
    }
}