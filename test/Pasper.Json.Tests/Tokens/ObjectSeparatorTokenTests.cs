using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class ObjectSeparatorTokenTests
{
    [Fact]
    public void Value_ShouldBeComma()
    {
        const string expected = ",";
        var token = new ObjectSeparatorToken();
        Assert.Equal(expected, token.Value);
    }
}