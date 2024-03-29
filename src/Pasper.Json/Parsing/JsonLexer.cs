using System.Text;

using Pasper.Json.Tokens;
using Pasper.Parsing;

namespace Pasper.Json.Parsing;

/// <summary>
/// Represents a lexer for JSON.
/// </summary>
/// <param name="json">The JSON string to read tokens from.</param>
public sealed class JsonLexer(string json)
    : ILexer
{
    private int _currentIndex;
    
    /// <inheritdoc/>
    public IToken? Previous { get; private set; }

    /// <inheritdoc/>
    public IToken? Current { get; private set; }

    /// <inheritdoc/>
    public void Dispose()
    {
        // TODO release managed resources here
    }

    /// <inheritdoc/>
    public bool MoveNext()
    {
        if (_currentIndex >= json.Length)
            return false;

        _priorToPrevious = Previous;
        Previous = Current;
        
        if (TryGetBeginCollection())
            return true;
        
        if (TryGetBeginObject())
            return true;

        if (TryGetBeginString())
            return true;
        
        if (TryGetKey())
            return true;
        
        if (TryGetKeyValueSeparator())
            return true;

        if (TryGetEndString())
            return true;
        
        if (TryGetObjectSeparator())
            return true;

        if (TryGetEndObject())
            return true;

        return TryGetEndCollection();
    }

    /// <inheritdoc/>
    public void Reset()
    {
        _currentIndex = 0;
        Previous = null;
        Current = null;
    }
    
    private bool TryGetBeginCollection()
    {
        if (json[_currentIndex] != '[')
            return false;

        Current = new BeginArray();
        _currentIndex++;
        return true;
    }
    
    private bool TryGetBeginObject()
    {
        if (json[_currentIndex] != '{')
            return false;

        Current = new BeginObject();
        _currentIndex++;
        return true;
    }
    
    private bool TryGetBeginString()
    {
        if (json[_currentIndex] != '"')
            return false;

        if (_priorToPrevious is BeginString)
            return false;
        
        Current = new BeginString();
        _currentIndex++;
        return true;
    }
    
    private bool TryGetKey()
    {
        if (json[_currentIndex] != '"')
            return false;

        if (_priorToPrevious is BeginString)
            return false;
        
        var key = new StringBuilder();
        _currentIndex++;
        
        while (json[_currentIndex] != '"')
        {
            key.Append(json[_currentIndex]);
            _currentIndex++;
        }

        Current = new PropertyName(key.ToString());
        return true;
    }
}