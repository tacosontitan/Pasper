using System.Collections;

namespace Pasper.Parsing;

/// <summary>
/// Represents a lexer for a serialization format.
/// </summary>
public interface ILexer
    : IEnumerator<IToken?>
{
    /// <summary>
    /// Gets the token at the previous position of the lexer.
    /// </summary>
    public IToken? Previous { get; }
}