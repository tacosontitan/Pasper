using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class KeyValueSeparatorTokenTests
{
    [Fact]
    public void Value_ShouldBeColon()
    {
        const string expected = ":";
        var token = new KeyValueSeparatorToken();
        Assert.Equal(expected, token.Value);
    }
}