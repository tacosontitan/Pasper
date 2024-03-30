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
    private int _lineNumber;
    private int _columnNumber;

    /// <inheritdoc/>
    public IToken? Previous { get; private set; }

    /// <inheritdoc/>
    public IToken? Current { get; private set; }

    /// <inheritdoc/>
    public bool MoveNext()
    {
        if (_currentIndex >= json.Length)
            return false;

        Previous = Current;
        return TryGetNextToken();
    }

    /// <inheritdoc/>
    public void Reset()
    {
        _currentIndex = 0;
        Previous = null;
        Current = null;
    }

    private bool TryGetNextToken()
    {
        SkipWhitespace();

        var currentChar = json[_currentIndex];
        IToken? currentToken = currentChar switch
        {
            '{' => new BeginObject(),
            '}' => new EndObject(),
            '[' => new BeginArray(),
            ']' => new EndArray(),
            _ => null
        };

        if (currentToken is not null)
        {
            Current = currentToken;
            _currentIndex++;
            return true;
        }

        throw new UnexpectedTokenException(_lineNumber, _columnNumber, currentChar.ToString());
    }

    private void SkipWhitespace()
    {
        while (_currentIndex < json.Length)
        {
            var currentChar = json[_currentIndex++];
            if (!char.IsWhiteSpace(currentChar))
                break;

            if (currentChar != '\n' && currentChar != '\r')
            {
                _columnNumber++;
                continue;
            }
            
            char? nextChar = _currentIndex < json.Length ? json[_currentIndex] : null;
            if (currentChar == '\r' && nextChar == '\n')
                _currentIndex++;
            
            _lineNumber++;
            _columnNumber = 0;
        }
    }
}