using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class KeyTokenTests
{
    [Fact]
    public void Value_ShouldBeKey()
    {
        const string expected = "key";
        var token = new KeyToken(expected);
        Assert.Equal(expected, token.Value);
    }
}