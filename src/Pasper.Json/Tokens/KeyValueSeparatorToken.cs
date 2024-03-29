using Pasper.Parsing;

namespace Pasper.Json.Tokens;

/// <summary>
/// Represents a token that separates a key from a value.
/// </summary>
/// <remarks>
///     This token is represented by the character <c>:</c>.
/// </remarks>
public sealed class KeyValueSeparatorToken
    : IToken
{
    /// <inheritdoc/>
    public string Value { get; } = ":";
}