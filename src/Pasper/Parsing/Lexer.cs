using System.Collections;

namespace Pasper.Parsing;

/// <summary>
/// Represents a lexer for a serialization format.
/// </summary>
public abstract class Lexer
    : ILexer
{
    private bool _disposed;

    /// <inheritdoc/>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <inheritdoc/>
    public abstract bool MoveNext();

    /// <inheritdoc/>
    public abstract void Reset();

    /// <inheritdoc/>
    public IToken? Current { get; protected set; }

    /// <inheritdoc/>
    object IEnumerator.Current =>
        Current!;

    /// <inheritdoc/>
    public IToken? Previous { get; protected set; }

    /// <summary>
    /// Releases the unmanaged resources used by the <see cref="Lexer"/> and optionally releases the managed resources.
    /// </summary>
    /// <param name="disposing">Indicates whether the method was called from the <see cref="Dispose"/> method.</param>
    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
            return;
        
        _disposed = true;
    }
}