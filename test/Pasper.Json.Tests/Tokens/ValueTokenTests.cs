using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class ValueTokenTests
{
    [Fact]
    public void Value_ShouldBeValue()
    {
        const string expected = "abc";
        var token = new ValueToken(expected);
        Assert.Equal(expected, token.Value);
    }
}