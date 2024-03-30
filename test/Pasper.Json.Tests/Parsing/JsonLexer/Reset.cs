using Pasper.Json.Parsing;

namespace Pasper.Json.Tests.Parsing;

public sealed partial class JsonLexerTests
{
    [Fact]
    public void Reset_ShouldResetLexer()
    {
        var lexer = new JsonLexer("{}");
        var tokenAvailable = lexer.MoveNext();
        Assert.True(tokenAvailable);
        Assert.NotNull(lexer.Current);
        
        tokenAvailable = lexer.MoveNext();
        Assert.True(tokenAvailable);
        Assert.NotNull(lexer.Current);
        Assert.NotNull(lexer.Previous);
        Assert.NotEqual(lexer.Current, lexer.Previous);
        
        lexer.Reset();
        Assert.Null(lexer.Current);
        Assert.Null(lexer.Previous);
    }
}