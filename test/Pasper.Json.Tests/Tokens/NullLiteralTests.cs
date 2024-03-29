using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class NullLiteralTests
{
    [Fact]
    public void Value_ShouldBeNull()
    {
        const string expected = "null";
        var token = new NullLiteral();
        Assert.Equal(expected, token.Value);
    }
}