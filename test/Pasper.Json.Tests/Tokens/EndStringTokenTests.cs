using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class EndStringTokenTests
{
    [Fact]
    public void Value_ShouldBeQuote()
    {
        const string expected = "\"";
        var token = new EndStringToken();
        Assert.Equal(expected, token.Value);
    }
}