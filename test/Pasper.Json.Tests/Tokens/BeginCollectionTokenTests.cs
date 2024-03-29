using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public sealed class BeginCollectionTokenTests
{
    [Fact]
    public void Value_ShouldBeOpenBracket()
    {
        const string expected = "[";
        var token = new BeginCollectionToken();
        Assert.Equal(expected, token.Value);
    }
}