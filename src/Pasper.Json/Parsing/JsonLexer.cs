using System.Diagnostics.CodeAnalysis;

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
        if (!TryGetNextToken(out var currentToken))
            return false;
        
        Previous = Current;
        Current = currentToken;
        return true;
    }

    /// <inheritdoc/>
    public void Reset()
    {
        _currentIndex = 0;
        Previous = null;
        Current = null;
    }

    private bool TryGetNextToken([NotNullWhen(true)] out IToken? token)
    {
        SkipIgnoredCharacters();
        if (_currentIndex >= json.Length)
        {
            token = null;
            return false;
        }

        var currentCharacter = json[_currentIndex];
        token = currentCharacter switch
        {
            '{' => new BeginObjectToken(),
            '}' => new EndObjectToken(),
            '[' => new BeginArrayToken(),
            ']' => new EndArrayToken(),
            _ => null
        };

        if (token is not null)
        {
            _currentIndex++;
            return true;
        }

        throw new UnexpectedTokenException(_lineNumber, _columnNumber, currentCharacter.ToString());
    }

    private void SkipIgnoredCharacters()
    {
        while (_currentIndex < json.Length)
        {
            var currentChar = json[_currentIndex];
            if (currentChar is ':' or ',')
            {
                _currentIndex++;
                continue;
            }

            if (!char.IsWhiteSpace(currentChar))
                break;

            if (currentChar != '\n' && currentChar != '\r')
            {
                _currentIndex++;
                _columnNumber++;
                continue;
            }
            
            char? nextChar = _currentIndex < json.Length ? json[_currentIndex] : null;
            if (currentChar == '\r' && nextChar == '\n')
                _currentIndex++;
            
            _lineNumber++;
            _currentIndex++;
            _columnNumber = 0;
        }
    }
}