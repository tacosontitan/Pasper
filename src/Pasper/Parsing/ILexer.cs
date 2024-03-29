namespace Pasper.Parsing;

/// <summary>
/// Represents a lexer for a serialization format.
/// </summary>
public interface ILexer
{
    /// <summary>
    /// Gets the token at the previous position of the lexer.
    /// </summary>
    public IToken? Previous { get; }
    
    /// <summary>
    /// Gets the token at the current position of the lexer.
    /// </summary>
    public IToken? Current { get; }
    
    /// <summary>
    /// Advances the lexer to the next token.
    /// </summary>
    /// <returns>
    ///     <see langword="true"/> if the lexer was successfully advanced to the next token;
    ///     otherwise, <see langword="false"/>.
    /// </returns>
    public bool MoveNext();
    
    /// <summary>
    /// Resets the lexer to its initial position.
    /// </summary>
    public void Reset();
}