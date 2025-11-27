namespace BFI.AST;

public class Loop : Node
{
    public List<Node> Body { get; set; } = [];

    public override void Execute(ExecutionContext ctx)
    {
        while (ctx.Tape[ctx.Pointer] != 0)
        {
            foreach (var node in Body)
                node.Execute(ctx);
        }
    }
}
