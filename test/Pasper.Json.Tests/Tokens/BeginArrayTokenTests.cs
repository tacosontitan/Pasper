using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public sealed class BeginArrayTokenTests
{
    [Fact]
    public void Value_ShouldBeOpenBracket()
    {
        const string expected = "[";
        var token = new BeginArrayToken();
        Assert.Equal(expected, token.Value);
    }
}