using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class LiteralTrueTokenTests
{
    [Fact]
    public void Value_ShouldBeTrue()
    {
        const string expected = "true";
        var token = new LiteralTrueToken();
        Assert.Equal(expected, token.Value);
    }
}