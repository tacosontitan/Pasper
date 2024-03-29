using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class BeginObjectTokenTests
{
    [Fact]
    public void Value_ShouldBeOpenBrace()
    {
        const string expected = "{";
        var token = new BeginObjectToken();
        Assert.Equal(expected, token.Value);
    }
}