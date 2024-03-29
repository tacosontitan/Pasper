using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class EndCollectionTokenTests
{
    [Fact]
    public void Value_ShouldBeCloseBracket()
    {
        const string expected = "]";
        var token = new EndCollectionToken();
        Assert.Equal(expected, token.Value);
    }
}