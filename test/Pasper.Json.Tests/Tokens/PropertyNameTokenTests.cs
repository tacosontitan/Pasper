using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class PropertyNameTokenTests
{
    [Fact]
    public void Value_ShouldBeKey()
    {
        const string expected = "key";
        var token = new PropertyNameToken(expected);
        Assert.Equal(expected, token.Value);
    }
}