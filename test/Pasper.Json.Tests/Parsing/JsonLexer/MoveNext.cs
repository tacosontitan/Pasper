using Pasper.Json.Parsing;
using Pasper.Json.Tokens;

namespace Pasper.Json.Tests.Parsing;

public sealed partial class JsonLexerTests
{
    [Fact]
    public void MoveNext_ShouldMoveToNextToken()
    {
        var lexer = new JsonLexer("{}");
        var tokenAvailable = lexer.MoveNext();
        Assert.True(tokenAvailable);
        Assert.NotNull(lexer.Current);
        Assert.IsType<BeginObjectToken>(lexer.Current);
        
        tokenAvailable = lexer.MoveNext();
        Assert.True(tokenAvailable);
        Assert.NotNull(lexer.Current);
        Assert.IsType<EndObjectToken>(lexer.Current);
    }
    
    [Fact]
    public void MoveNext_ShouldReturnFalseWhenNoMoreTokens()
    {
        var lexer = new JsonLexer("{}");
        var tokenAvailable = lexer.MoveNext();
        Assert.True(tokenAvailable);
        Assert.NotNull(lexer.Current);
        
        tokenAvailable = lexer.MoveNext();
        Assert.True(tokenAvailable);
        Assert.NotNull(lexer.Current);
        
        tokenAvailable = lexer.MoveNext();
        Assert.False(tokenAvailable);
    }
    
    [Fact]
    public void MoveNext_ShouldReturnFalseWhenNoTokens()
    {
        var lexer = new JsonLexer("");
        var tokenAvailable = lexer.MoveNext();
        Assert.False(tokenAvailable);
    }
    
    [Fact]
    public void MoveNext_ShouldSetPreviousToken()
    {
        var lexer = new JsonLexer("{}");
        var tokenAvailable = lexer.MoveNext();
        Assert.True(tokenAvailable);
        Assert.NotNull(lexer.Current);
        Assert.Null(lexer.Previous);
        
        tokenAvailable = lexer.MoveNext();
        Assert.True(tokenAvailable);
        Assert.NotNull(lexer.Current);
        Assert.NotNull(lexer.Previous);
        Assert.IsType<BeginObjectToken>(lexer.Previous);
    }
}