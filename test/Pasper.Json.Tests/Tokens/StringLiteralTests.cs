using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class StringLiteralTests
{
    [Fact]
    public void Value_ShouldBeValue()
    {
        const string expected = "abc";
        var token = new StringLiteral(expected);
        Assert.Equal(expected, token.Value);
    }
}