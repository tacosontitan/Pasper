using Pasper.Parsing;

namespace Pasper.Json.Tokens;

/// <summary>
/// Represents a token that indicates the colon separator.
/// </summary>
public sealed class EndNameToken
    : IToken
{
    /// <inheritdoc/>
    public string Value { get; } = ":";
}