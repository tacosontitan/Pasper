using Pasper.Parsing;

namespace Pasper.Json.Tokens;

/// <summary>
/// Represents a token that indicates the beginning of an object.
/// </summary>
/// <remarks>
///     This token is represented by the character <c>{</c>.
/// </remarks>
public sealed class BeginObject
    : IToken
{
    /// <inheritdoc/>
    public string Value { get; } = "{";
}