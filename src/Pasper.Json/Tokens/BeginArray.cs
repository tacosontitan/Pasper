using System.Diagnostics.CodeAnalysis;

using Pasper.Parsing;

namespace Pasper.Json.Tokens;

/// <summary>
/// Represents a token that indicates the beginning of a collection.
/// </summary>
/// <remarks>
///     This token is represented by the character <c>[</c>.
/// </remarks>
public sealed class BeginArray()
    : IToken
{
    /// <inheritdoc/>
    public string Value { get; } = "[";
}