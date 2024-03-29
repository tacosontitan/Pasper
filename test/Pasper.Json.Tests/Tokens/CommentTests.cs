using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Tokens;

public class CommentTests
{
    [Fact]
    public void Value_ShouldBeSlashSlash()
    {
        const string expected = "abc";
        var token = new Comment(expected);
        Assert.Equal(expected, token.Value);
    }
}