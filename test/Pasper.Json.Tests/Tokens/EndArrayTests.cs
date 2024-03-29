using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class EndArrayTests
{
    [Fact]
    public void Value_ShouldBeCloseBracket()
    {
        const string expected = "]";
        var token = new EndArray();
        Assert.Equal(expected, token.Value);
    }
}