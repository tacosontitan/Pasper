using Pasper.Parsing;

namespace Pasper.Json.Tokens;

/// <summary>
/// Represents a token containing the literal value <c>false</c>.
/// </summary>
public sealed class FalseLiteral
    : IToken
{
    /// <inheritdoc/>
    public string Value { get; } = "false";
}