using System.Diagnostics.CodeAnalysis;

namespace Pasper.Parsing;

/// <summary>
/// Represents an exception that is thrown when an unexpected token is encountered.
/// </summary>
/// <param name="line">The line number where the unexpected token was encountered.</param>
/// <param name="column">The column number where the unexpected token was encountered.</param>
/// <param name="token">The unexpected token that was encountered.</param>
/// <param name="innerException">The exception that is the cause of the current exception.</param>
[SuppressMessage("Design", "CA1032:Implement standard exception constructors")]
public sealed class UnexpectedTokenException(
    int line,
    int column,
    string token,
    Exception? innerException = null
) : Exception(message: $"Unexpected token '{token}' at line {line}, column {column}.", innerException)
{
    /// <summary>
    /// Gets the line number where the unexpected token was encountered.
    /// </summary>
    public int Line { get; } = line;

    /// <summary>
    /// Gets the column number where the unexpected token was encountered.
    /// </summary>
    public int Column { get; } = column;

    /// <summary>
    /// Gets the unexpected token that was encountered.
    /// </summary>
    public string Token { get; } = token;
}