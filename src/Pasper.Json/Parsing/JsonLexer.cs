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
            ':' => new EndNameToken(),
            ',' => new EndValueToken(),
            _ => null
        };

        if (token is not null)
        {
            _currentIndex++;
            return true;
        }

        if (TryGetStringToken(out token))
            return true;

        if (TryGetSingleLineCommentToken(out token))
            return true;

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

    private bool TryGetStringToken([NotNullWhen(true)] out IToken? token)
    {
        if (json[_currentIndex] != '"')
        {
            token = null;
            return false;
        }
        
        var startIndex = _currentIndex;
        var endIndex = json.IndexOf('"', startIndex + 1);
        if (endIndex == -1)
            throw new UnexpectedTokenException(_lineNumber, _columnNumber, "EOF");
        
        var value = json.Substring(startIndex + 1, endIndex - startIndex - 1);
        token = Previous switch
        {
            EndNameToken => new LiteralStringToken(value),
            BeginObjectToken or EndValueToken => new PropertyNameToken(value),
            _ => throw new UnexpectedTokenException(_lineNumber, _columnNumber, value)
        };
        
        _currentIndex = endIndex + 1;
        return true;
    }

    private bool TryGetSingleLineCommentToken([NotNullWhen(true)] out IToken? token)
    {
        if (json[_currentIndex] != '/')
        {
            token = null;
            return false;
        }
        
        var nextToken = json[_currentIndex + 1];
        if (nextToken is not '/')
        {
            token = null;
            return false;
        }
        
        // Single line comments can technically be placed on the final line of the specified
        // input. The lexer accounts for this by assuming that if no line breaks are detected
        // after the start of a comment, that the comment goes to the end of the input.
        var startIndex = _currentIndex + 2;
        var endIndex = json.IndexOf('\n', startIndex);
        if (endIndex == -1)
            endIndex = json.Length;
        
        var value = json.Substring(startIndex, endIndex - startIndex);
        token = new CommentToken(value.Trim());
        _currentIndex = endIndex + 1;
        _columnNumber += value.Length + 2;
        return true;
    }
}