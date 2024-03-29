using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class BeginStringTokenTests
{
    [Fact]
    public void Value_ShouldBeQuote()
    {
        const string expected = "\"";
        var token = new BeginStringToken();
        Assert.Equal(expected, token.Value);
    }
}