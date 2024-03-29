using Pasper.Parsing;

namespace Pasper.Json.Tokens;

/// <summary>
/// Represents a token that marks the end of a string.
/// </summary>
/// <remarks>
///     This token is represented by the character <c>"</c>.
/// </remarks>
public sealed class EndStringToken
    : IToken
{
    /// <inheritdoc/>
    public string Value { get; } = "\"";
}