using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public sealed class BeginArrayTests
{
    [Fact]
    public void Value_ShouldBeOpenBracket()
    {
        const string expected = "[";
        var token = new BeginArray();
        Assert.Equal(expected, token.Value);
    }
}