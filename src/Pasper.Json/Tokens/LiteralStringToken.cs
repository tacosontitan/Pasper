using Pasper.Parsing;

namespace Pasper.Json.Tokens;

/// <summary>
/// Represents a token containing a value.
/// </summary>
public sealed class LiteralStringToken(string value)
    : IToken
{
    /// <inheritdoc/>
    public string Value { get; } = value;
}