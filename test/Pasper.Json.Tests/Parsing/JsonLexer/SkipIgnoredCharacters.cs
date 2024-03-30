using Pasper.Json.Parsing;

namespace Pasper.Json.Tests.Parsing;

public sealed partial class JsonLexerTests
{
    [Theory]
    [InlineData(" ")]
    [InlineData("\t")]
    [InlineData("\n")]
    [InlineData("\r")]
    [InlineData("\r\n")]
    [InlineData(":")]
    [InlineData(",")]
    public void SkipIgnoredCharacters(string input)
    {
        var lexer = new JsonLexer(input);
        var tokenAvailable = lexer.MoveNext();
        Assert.False(tokenAvailable);
        Assert.Null(lexer.Current);
    }
}