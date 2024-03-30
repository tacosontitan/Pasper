using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class LiteralStringTokenTests
{
    [Fact]
    public void Value_ShouldBeValue()
    {
        const string expected = "abc";
        var token = new LiteralStringToken(expected);
        Assert.Equal(expected, token.Value);
    }
}