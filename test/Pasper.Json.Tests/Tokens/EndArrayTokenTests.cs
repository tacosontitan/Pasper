using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class EndArrayTokenTests
{
    [Fact]
    public void Value_ShouldBeCloseBracket()
    {
        const string expected = "]";
        var token = new EndArrayToken();
        Assert.Equal(expected, token.Value);
    }
}