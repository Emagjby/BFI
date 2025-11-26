namespace BFI.Lexing;

public class Tokenizer
{
    private readonly string _source;

    public Tokenizer(string source)
    {
        _source = source;
    }

    public List<Token> Tokenize()
    {
        List<Token> tokens = [];

        foreach (var c in _source)
        {
            switch (c)
            {
                case '>':
                    tokens.Add(new Token(TokenType.MoveRight));
                    break;
                case '<':
                    tokens.Add(new Token(TokenType.MoveLeft));
                    break;
                case '+':
                    tokens.Add(new Token(TokenType.Increment));
                    break;
                case '-':
                    tokens.Add(new Token(TokenType.Decrement));
                    break;
                case '.':
                    tokens.Add(new Token(TokenType.Print));
                    break;
                case ',':
                    tokens.Add(new Token(TokenType.Input));
                    break;
                case '[':
                    tokens.Add(new Token(TokenType.LoopStart));
                    break;
                case ']':
                    tokens.Add(new Token(TokenType.LoopEnd));
                    break;
                default:
                    break;
            }
        }

        return tokens;
    }
}
