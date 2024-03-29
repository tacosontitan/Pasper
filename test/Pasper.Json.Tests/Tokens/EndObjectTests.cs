using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class EndObjectTests
{
    [Fact]
    public void Value_ShouldBeCloseBrace()
    {
        const string expected = "}";
        var token = new EndObject();
        Assert.Equal(expected, token.Value);
    }
}