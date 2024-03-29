using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class EndObjectTokenTests
{
    [Fact]
    public void Value_ShouldBeCloseBrace()
    {
        const string expected = "}";
        var token = new EndObjectToken();
        Assert.Equal(expected, token.Value);
    }
}