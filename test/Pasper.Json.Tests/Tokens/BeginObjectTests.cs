using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class BeginObjectTests
{
    [Fact]
    public void Value_ShouldBeOpenBrace()
    {
        const string expected = "{";
        var token = new BeginObject();
        Assert.Equal(expected, token.Value);
    }
}