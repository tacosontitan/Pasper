using Pasper.Parsing;

namespace Pasper.Json.Tokens;

/// <summary>
/// Represents a token containing a comment.
/// </summary>
/// <param name="value">The value of the comment.</param>
public sealed class Comment(string value)
    : IToken
{
    /// <summary>
    /// Gets the value of the comment.
    /// </summary>
    public string Value { get; } = value;
}