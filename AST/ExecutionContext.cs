namespace BFI.AST;

public class ExecutionContext
{
    public byte[] Tape { get; }
    public int Pointer { get; set; }

    public ExecutionContext(int size = 30_000)
    {
        Tape = new byte[size];
        Pointer = 0;
    }
}
