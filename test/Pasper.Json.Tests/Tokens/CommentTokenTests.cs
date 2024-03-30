using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class CommentTokenTests
{
    [Fact]
    public void Value_ShouldBeSlashSlash()
    {
        const string expected = "abc";
        var token = new CommentToken(expected);
        Assert.Equal(expected, token.Value);
    }
}