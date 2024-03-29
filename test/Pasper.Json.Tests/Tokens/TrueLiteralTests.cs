using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class TrueLiteralTests
{
    [Fact]
    public void Value_ShouldBeTrue()
    {
        const string expected = "true";
        var token = new TrueLiteral();
        Assert.Equal(expected, token.Value);
    }
}