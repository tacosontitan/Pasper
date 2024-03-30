using Pasper.Parsing;

namespace Pasper.Json.Tokens;

/// <summary>
/// Represents a token containing a number.
/// </summary>
public sealed class LiteralNumberToken(string value)
    : IToken
{
    /// <inheritdoc/>
    public string Value { get; } = value;
}