using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class NumberLiteralTests
{
    [Fact]
    public void Value_ShouldBeNumber()
    {
        const string expected = "123";
        var token = new NumberLiteral("123");
        Assert.Equal(expected, token.Value);
    }
}