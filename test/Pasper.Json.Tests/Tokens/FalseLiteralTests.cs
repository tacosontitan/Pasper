using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class FalseLiteralTests
{
    [Fact]
    public void Value_ShouldBeFalse()
    {
        const string expected = "false";
        var token = new FalseLiteral();
        Assert.Equal(expected, token.Value);
    }
}