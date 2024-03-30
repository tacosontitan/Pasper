using Pasper.Parsing;

namespace Pasper.Json.Tokens;

/// <summary>
/// Represents a token that indicates the comma separator.
/// </summary>
public sealed class EndValueToken
    : IToken
{
    /// <inheritdoc/>
    public string Value { get; } = ",";
}