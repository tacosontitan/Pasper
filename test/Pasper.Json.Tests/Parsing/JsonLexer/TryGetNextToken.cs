using Pasper.Json.Parsing;
using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Parsing;

public sealed partial class JsonLexerTests
{
    [Fact]
    public void TryGetNextToken_BeginArrayDetected_ReturnsTrue()
    {
        var lexer = new JsonLexer("[");
        var tokenAvailable = lexer.MoveNext();
        Assert.True(tokenAvailable);
        Assert.NotNull(lexer.Current);
        Assert.IsType<BeginArrayToken>(lexer.Current);
    }
    
    [Fact]
    public void TryGetNextToken_EndArrayDetected_ReturnsTrue()
    {
        var lexer = new JsonLexer("]");
        var tokenAvailable = lexer.MoveNext();
        Assert.True(tokenAvailable);
        Assert.NotNull(lexer.Current);
        Assert.IsType<EndArrayToken>(lexer.Current);
    }
    
    [Fact]
    public void TryGetNextToken_BeginObjectDetected_ReturnsTrue()
    {
        var lexer = new JsonLexer("{");
        var tokenAvailable = lexer.MoveNext();
        Assert.True(tokenAvailable);
        Assert.NotNull(lexer.Current);
        Assert.IsType<BeginObjectToken>(lexer.Current);
    }
    
    [Fact]
    public void TryGetNextToken_EndObjectDetected_ReturnsTrue()
    {
        var lexer = new JsonLexer("}");
        var tokenAvailable = lexer.MoveNext();
        Assert.True(tokenAvailable);
        Assert.NotNull(lexer.Current);
        Assert.IsType<EndObjectToken>(lexer.Current);
    }

    [Fact]
    public void TryGetNextToken_CommentDetected_ReturnsTrue()
    {
        const string comment = "this is a comment";
        const string testJson = $"// {comment}";
        var lexer = new JsonLexer(testJson);
        var tokenAvailable = lexer.MoveNext();
        Assert.True(tokenAvailable);
        Assert.NotNull(lexer.Current);
        Assert.IsType<CommentToken>(lexer.Current);
        Assert.Equal(comment, lexer.Current.Value);
    }
}