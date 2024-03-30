using Pasper.Parsing;

namespace Pasper.Json.Tokens;

/// <summary>
/// Represents a token that indicates the literal value <c>true</c>.
/// </summary>
public sealed class LiteralTrueToken
    : IToken
{
    /// <inheritdoc/>
    public string Value { get; } = "true";
}