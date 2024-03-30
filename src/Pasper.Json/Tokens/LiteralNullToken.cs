using Pasper.Parsing;

namespace Pasper.Json.Tokens;

/// <summary>
/// Represents a token that indicates the literal value <c>null</c>.
/// </summary>
public sealed class LiteralNullToken
    : IToken
{
    /// <inheritdoc/>
    public string Value { get; } = "null";
}