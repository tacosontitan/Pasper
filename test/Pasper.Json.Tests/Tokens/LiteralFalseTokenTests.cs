using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class LiteralFalseTokenTests
{
    [Fact]
    public void Value_ShouldBeFalse()
    {
        const string expected = "false";
        var token = new LiteralFalseToken();
        Assert.Equal(expected, token.Value);
    }
}