namespace BFI.Lexing;

public struct Token
{
    public TokenType Type { get; }

    public Token(TokenType type)
    {
        Type = type;
    }

    public override string ToString() => Type.ToString();
}
