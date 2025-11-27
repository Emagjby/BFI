using BFI.Lexing;

namespace BFI.AST;

public class SimpleOp : Node
{
    public TokenType Operation { get; }

    public SimpleOp(TokenType operation)
    {
        Operation = operation;
    }

    public override void Execute(ExecutionContext ctx)
    {
        switch (Operation)
        {
            case TokenType.Increment:
                ctx.Tape[ctx.Pointer]++;
                break;

            case TokenType.Decrement:
                ctx.Tape[ctx.Pointer]--;
                break;

            case TokenType.MoveLeft:
                ctx.Pointer--;
                break;

            case TokenType.MoveRight:
                ctx.Pointer++;
                break;

            case TokenType.Print:
                Console.Write((char)ctx.Tape[ctx.Pointer]);
                break;

            case TokenType.Input:
                ctx.Tape[ctx.Pointer] = (byte)Console.Read();
                break;
        }
    }
}
