using BFI.AST;
using BFI.Lexing;

namespace BFI.Parsing;

public class Parser
{
    private readonly List<Token> _tokens;

    public Parser(List<Token> tokens)
    {
        _tokens = tokens;
    }

    public List<Node> Parse()
    {
        List<Node> root = [];
        Stack<List<Node>> stack = [];
        stack.Push(root);

        foreach (var token in _tokens)
        {
            switch (token.Type)
            {
                case TokenType.Increment:
                case TokenType.Decrement:
                case TokenType.MoveRight:
                case TokenType.MoveLeft:
                case TokenType.Print:
                case TokenType.Input:
                    stack.Peek().Add(new SimpleOp(token.Type));
                    break;

                case TokenType.LoopStart:
                    var loop = new Loop();
                    stack.Peek().Add(loop);
                    stack.Push(loop.Body);
                    break;

                case TokenType.LoopEnd:
                    stack.Pop();
                    break;
            }
        }

        return root;
    }
}
