namespace Pasper.Parsing;

/// <summary>
/// Represents a token within a serialization format.
/// </summary>
public interface IToken
{
    /// <summary>
    /// Gets the value of the token.
    /// </summary>
    public string Value { get; }
}