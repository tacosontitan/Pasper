using Pasper.Parsing;

namespace Pasper.Json.Tokens;

/// <summary>
/// Represents a token that separates objects.
/// </summary>
/// <remarks>
///     This token is represented by the character <c>,</c>.
/// </remarks>
public sealed class ObjectSeparatorToken
    : IToken
{
    /// <inheritdoc/>
    public string Value { get; } = ",";
}