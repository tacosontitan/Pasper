using Pasper.Parsing;

namespace Pasper.Json.Tokens;

/// <summary>
/// Represents a token containing a key.
/// </summary>
public sealed class PropertyName(string key)
    : IToken
{
    /// <inheritdoc/>
    public string Value { get; } = key;
}