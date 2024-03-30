using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class LiteralNullTokenTests
{
    [Fact]
    public void Value_ShouldBeNull()
    {
        const string expected = "null";
        var token = new LiteralNullToken();
        Assert.Equal(expected, token.Value);
    }
}