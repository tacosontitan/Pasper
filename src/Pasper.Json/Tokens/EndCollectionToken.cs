using Pasper.Parsing;

namespace Pasper.Json.Tokens;

/// <summary>
/// Represents a token that marks the end of a collection.
/// </summary>
/// <remarks>
///     This token is represented by the character <c>]</c>.
/// </remarks>
public sealed class EndCollectionToken
    : IToken
{
    /// <inheritdoc/>
    public string Value { get; } = "]";
}